/******************************************************************************
    convert phpbb3 mysql database to wordpress export xml file.
    
    Copyright (C) 2015 George Fang <grgfang@gmail.com>

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
******************************************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Web;
using MySql.Data.MySqlClient;

namespace phpbb3_to_wp
{
    public partial class frmMain : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        string[] aryP2A;
        string[] aryTag;
        Dictionary<string, string> dicTag = new Dictionary<string, string>();
        Dictionary<string, string> dicBBCodeHtmlTag = new Dictionary<string, string>();
        Dictionary<string, string> dicBBCodePattern = new Dictionary<string, string>();
        int addMoreTagAfterPost = 1;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnWordpressBaseXmlBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = txtWordpressBaseXml.Text;

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtWordpressBaseXml.Text = openFileDialog1.FileName;
            }
        }

        private void btnGetForumList_Click(object sender, EventArgs e)
        {
            // get Forum List
            dgvForumList.Rows.Clear();

            GetForumListByParentID(0, true);

            // get User List
            GetUserList();
        }

        void GetForumListByParentID(int parent_id, bool tree_flag = false, int tree_level = 0)
        {
            string connStr = txtMySQLphpbb3ConnStr.Text;

            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();

                cmd = new MySqlCommand();
                cmd.Connection = conn;

                string sql = @"
select t1.forum_id
  , t1.forum_name
  , t1.parent_id
  , t2.forum_name as parent_forum_name
from " + txtTablePrefix.Text + @"forums as t1
left join " + txtTablePrefix.Text + @"forums as t2 on t1.parent_id = t2.forum_id
where t1.parent_id = @parent_id
order by t1.parent_id
  , t1.left_id
;";

                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@parent_id", parent_id);

                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adp.Fill(dt);

                cmd.Dispose();
                conn.Dispose();

                // add to datagridview
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int row_id = dgvForumList.Rows.Add();

                    dgvForumList.Rows[row_id].Cells["tree"].Value = (tree_level == 0 ? "" : new String('-', tree_level) + "") + dt.Rows[i]["forum_name"].ToString();
                    dgvForumList.Rows[row_id].Cells["forum_id"].Value = dt.Rows[i]["forum_id"].ToString();
                    dgvForumList.Rows[row_id].Cells["forum_name"].Value = dt.Rows[i]["forum_name"].ToString();
                    dgvForumList.Rows[row_id].Cells["parent_id"].Value = dt.Rows[i]["parent_id"].ToString();
                    dgvForumList.Rows[row_id].Cells["parent_forum_name"].Value = dt.Rows[i]["parent_forum_name"].ToString();

                    if (tree_flag == true)
                    {
                        GetForumListByParentID(int.Parse(dt.Rows[i]["forum_id"].ToString()), tree_flag, tree_level + 1);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void GetUserList()
        {
            dgvUserList.Rows.Clear();

            string connStr = txtMySQLphpbb3ConnStr.Text;

            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();

                cmd = new MySqlCommand();
                cmd.Connection = conn;

                string sql = @"
select user_id
  , t1.username
  , t1.user_email
from " + txtTablePrefix.Text + @"users as t1
order by t1.username
;";

                cmd.CommandText = sql;

                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                adp.Fill(dt);

                cmd.Dispose();
                conn.Dispose();

                // add to datagridview
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    int row_id = dgvUserList.Rows.Add();

                    dgvUserList.Rows[row_id].Cells["Flag"].Value = "";
                    dgvUserList.Rows[row_id].Cells["UserID"].Value = dt.Rows[i]["user_id"].ToString();
                    dgvUserList.Rows[row_id].Cells["UserName"].Value = dt.Rows[i]["username"].ToString();
                    dgvUserList.Rows[row_id].Cells["UserEMail"].Value = dt.Rows[i]["user_email"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            txtMySQLphpbb3ConnStr.Text = Properties.Settings.Default.MySQLphpbb3ConnStr;
            txtTablePrefix.Text = Properties.Settings.Default.TablePrefix;
            txtP2ADefault.Text = Properties.Settings.Default.P2ADefault;
            txtP2AReMapping.Text = Properties.Settings.Default.P2AReMapping;
            txtWordpressBaseXml.Text = Properties.Settings.Default.WordpressBaseXML;
            txtTagList.Text = Properties.Settings.Default.TagList;
            txtBBCodeToHtmlTag.Text = Properties.Settings.Default.BBCodeToHtmlTag;
            txtExcludeTopicsID.Text = Properties.Settings.Default.ExcludeTopicsID;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.MySQLphpbb3ConnStr = txtMySQLphpbb3ConnStr.Text;
            Properties.Settings.Default.TablePrefix = txtTablePrefix.Text;
            Properties.Settings.Default.P2ADefault = txtP2ADefault.Text;
            Properties.Settings.Default.P2AReMapping = txtP2AReMapping.Text;
            Properties.Settings.Default.WordpressBaseXML = txtWordpressBaseXml.Text;
            Properties.Settings.Default.TagList = txtTagList.Text;
            Properties.Settings.Default.BBCodeToHtmlTag = txtBBCodeToHtmlTag.Text;
            Properties.Settings.Default.ExcludeTopicsID = txtExcludeTopicsID.Text;

            Properties.Settings.Default.Save();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Check Forum is selected
            if (dgvForumList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a Forum.");
                return;
            }
            // Check wordpress_base.xml is existed
            if (File.Exists(txtWordpressBaseXml.Text) == false)
            {
                MessageBox.Show("File dos not exist: " + txtWordpressBaseXml);
                return;
            }
            
            GenerateXML();

            MessageBox.Show("Generate Finished!");

            //this.Close();
        }

        void GenerateXML()
        {
            aryP2A = null;
            aryTag = null;
            dicTag.Clear();
            dicBBCodeHtmlTag.Clear();
            dicBBCodePattern.Clear();

            if (int.TryParse(txtAddMoreTagAfterPost.Text, out addMoreTagAfterPost) == false) { addMoreTagAfterPost = 1; }
            if (addMoreTagAfterPost < 1) { addMoreTagAfterPost = 1; }

            lstUnmappedBBCode.Items.Clear();
            foreach (DataGridViewRow dgvr in dgvUserList.Rows)
            {
                dgvr.Cells["Flag"].Value = "";
            }

            WriteLog("");
            WriteLog("Start");

            // get server_name
            string server_name = GetConfigValue("server_name");
            string server_port = GetConfigValue("server_port");
            string server_protocol = GetConfigValue("server_protocol");
            string script_path = GetConfigValue("script_path");
            string root_url = server_protocol + server_name + (server_port == "80" ? "" : ":" + server_port) + script_path;
            
            // ref. wordpress: formatting.php and export xml file.
            // ref. phpbb3: functions_content.php and generate webpage.

            // forum id
            int forum_id = int.Parse(dgvForumList.SelectedRows[0].Cells["forum_id"].Value.ToString());
            int forum_row_index = dgvForumList.SelectedRows[0].Index;
            string forum_name = dgvForumList.SelectedRows[0].Cells["Forum_Name"].Value.ToString();

            WriteLog(string.Format("Forum id={0}, name={1}", forum_id, forum_name));

            // file name
            string file_name_without_ext = Path.GetFileNameWithoutExtension(txtWordpressBaseXml.Text);
            string ext_name = Path.GetExtension(txtWordpressBaseXml.Text);

            string out_full_name = Application.StartupPath + @"\" + file_name_without_ext;
            out_full_name += "_" + forum_id.ToString();
            if (rdoSelTopicsAll.Checked) { out_full_name += "_all"; }
            if (rdoSelTopicsRange.Checked) { out_full_name += "_range_" + txtSelTopicsFrom.Text + "_" + txtSelTopicsTo; }
            out_full_name += "_" + forum_name;
            out_full_name += ext_name;
            //MessageBox.Show(out_full_name);

            // Read output content from wordpress_base.xml
            string out_content = File.ReadAllText(txtWordpressBaseXml.Text);

            // fill %%created%%
            out_content = out_content.Replace("%%created%%", DateTime.Now.ToString("yyyy-MM-dd HH:mm"));

            // fill %%pubDate%%
            out_content = out_content.Replace("%%pubDate%%", DateTime.Now.ToString("ddd, dd MMM yyyy HH:mm:ss", CultureInfo.CreateSpecificCulture("en-US")));

            // fill %%category%%
            string out_category = "";
            int tmp_forum_row_index = forum_row_index;
            string item_category_nicename = ""; // for item category
            string item_category_CDATA = ""; // for item category
            while (true)
            {
                int tmp_forum_id = int.Parse(dgvForumList.Rows[tmp_forum_row_index].Cells["forum_id"].Value.ToString());
                string tmp_forum_name = dgvForumList.Rows[tmp_forum_row_index].Cells["forum_name"].Value.ToString();
                string tmp_parent_forum_name = dgvForumList.Rows[tmp_forum_row_index].Cells["parent_forum_name"].Value.ToString();
                int tmp_parent_id = int.Parse(dgvForumList.Rows[tmp_forum_row_index].Cells["parent_id"].Value.ToString());

                string tmp_category = "	<wp:category><wp:term_id>%%term_id%%</wp:term_id><wp:category_nicename>%%category_nicename%%</wp:category_nicename><wp:category_parent>%%category_parent%%</wp:category_parent><wp:cat_name><![CDATA[%%cat_name%%]]></wp:cat_name></wp:category>\r\n";
                // fill %%term_id%%
                tmp_category = tmp_category.Replace("%%term_id%%", tmp_forum_id.ToString());
                // fill %%category_nicename%%
                tmp_category = tmp_category.Replace("%%category_nicename%%", Util.generate_slug(tmp_forum_name));
                if (item_category_nicename == "") { item_category_nicename = Util.generate_slug(tmp_forum_name); }
                // fill %%category_parent%%
                tmp_category = tmp_category.Replace("%%category_parent%%", Util.generate_slug(tmp_parent_forum_name));
                // fill %%cat_name%%
                tmp_category = tmp_category.Replace("%%cat_name%%", Util.CDATA_safe(tmp_forum_name));
                if (item_category_CDATA == "") { item_category_CDATA = Util.CDATA_safe(tmp_forum_name); }

                tmp_category = tmp_category.Replace("<wp:category_parent></wp:category_parent>", "<wp:category_parent/>");

                out_category = tmp_category + out_category;

                // find parent forum
                if (tmp_parent_id == 0) { break; }
                tmp_forum_row_index = -1;
                for (int i = 0; i < dgvForumList.Rows.Count; i++)
                {
                    if (int.Parse(dgvForumList.Rows[i].Cells["forum_id"].Value.ToString()) == tmp_parent_id)
                    {
                        tmp_forum_row_index = i;
                        break;
                    }
                }
                if (tmp_forum_row_index == -1) { break; } // parent forum does not exist
            }
            out_content = out_content.Replace("%%category%%", out_category);

            // file %%item%%
            string out_item = "";
            string out_item_category = @"<category domain=""category"" nicename=""%%item_category_nicename%%""><![CDATA[%%item_category_CDATA%%]]></category>";
            out_item_category = out_item_category.Replace("%%item_category_nicename%%", item_category_nicename);
            out_item_category = out_item_category.Replace("%%item_category_CDATA%%", item_category_CDATA);

            DataTable dt_topics = GetTopicByForumID(forum_id);

            int selTopicsFrom = 0;
            int selTopicsTo = dt_topics.Rows.Count - 1;
            if (rdoSelTopicsRange.Checked)
            {
                if (int.TryParse(txtSelTopicsFrom.Text, out selTopicsFrom) == false) { selTopicsFrom = 0; }
                if (int.TryParse(txtSelTopicsTo.Text, out selTopicsTo) == false) { selTopicsTo = dt_topics.Rows.Count - 1; }
            }
            string exclude_topics_id = "," + txtExcludeTopicsID.Text.Replace("\r", ",").Replace("\n", ",").Replace(",,", ",") + ",";

            for (int i = selTopicsFrom; i <= selTopicsTo; i++)
            {
                string tmp_item = @"
	<item>
		<title>%%title%%</title>
		<link>%%link%%</link>
		<pubDate>%%pubDate%%</pubDate>
		<dc:creator><![CDATA[%%creator%%]]></dc:creator>
		<guid isPermaLink=""false"">%%guid%%</guid>
		<description></description>
		<content:encoded><![CDATA[%%content_encoded%%]]></content:encoded>
		<excerpt:encoded><![CDATA[]]></excerpt:encoded>
		<wp:post_id>%%post_id%%</wp:post_id>
		<wp:post_date>%%post_date%%</wp:post_date>
		<wp:post_date_gmt>%%post_date_gmt%%</wp:post_date_gmt>
		<wp:comment_status>open</wp:comment_status>
		<wp:ping_status>open</wp:ping_status>
		<wp:post_name>%%post_name%%</wp:post_name>
		<wp:status>publish</wp:status>
		<wp:post_parent>0</wp:post_parent>
		<wp:menu_order>0</wp:menu_order>
		<wp:post_type>post</wp:post_type>
		<wp:post_password></wp:post_password>
		<wp:is_sticky>0</wp:is_sticky>
        %%item_post_tag%%
        %%item_category%%
	</item>
";
                int tmp_topic_id = int.Parse(dt_topics.Rows[i]["topic_id"].ToString());
                if (exclude_topics_id.IndexOf("," + tmp_topic_id.ToString() + ",") != -1) { continue; }

                // fill %%title%%
                tmp_item = tmp_item.Replace("%%title%%", dt_topics.Rows[i]["topic_title"].ToString());
                // fill %%link%%
                tmp_item = tmp_item.Replace("%%link%%", "http://localhost/wordpress/?p=" + tmp_topic_id.ToString());
                // fill %%pubDate%%
                tmp_item = tmp_item.Replace("%%pubDate%%", dt_topics.Rows[i]["pubDate"].ToString());
                // fill %%creator%%
                string tmp_creator = dt_topics.Rows[i]["username"].ToString();
                tmp_item = tmp_item.Replace("%%creator%%", Util.CDATA_safe(tmp_creator));
                // fill %%guid%%
                tmp_item = tmp_item.Replace("%%guid%%", "http://localhost/wordpress/?p=" + tmp_topic_id.ToString());
                // fill %%post_id%%
                tmp_item = tmp_item.Replace("%%post_id%%", tmp_topic_id.ToString());
                // fill %%item_category%%
                tmp_item = tmp_item.Replace("%%item_category%%", out_item_category);

                WriteLog(string.Format("Topic index={0}, id={1}, title={2}", i, tmp_topic_id, dt_topics.Rows[i]["topic_title"].ToString()));

                // fill %%content_encoded%%
                string tmp_content_encoded = "";
                string tmp_post_name_topic = "";
                DataTable dt_posts = GetPostByTopicID(tmp_topic_id);
                for (int j = 0; j < dt_posts.Rows.Count; j++ )
                {
                    string tmp_post_name = dt_posts.Rows[j]["post_username"].ToString();
                    string tmp_post_text = dt_posts.Rows[j]["post_text"].ToString();
                    string tmp_bbcode_uid = dt_posts.Rows[j]["bbcode_uid"].ToString();

                    string tmp_post_name_remap = PosterRemap(tmp_post_name);
                    tmp_post_text = ConvertBBCode(tmp_post_text, tmp_bbcode_uid);

                    // mark available poster
                    foreach(DataGridViewRow dgvr in dgvUserList.Rows)
                    {
                        if (dgvr.Cells["UserName"].Value.ToString() == tmp_post_name_remap)
                        {
                            dgvr.Cells["Flag"].Value = "*";
                        }
                    }

                    // generate content_encoded
                    if (j == 0)
                    {
                        tmp_post_name_topic = tmp_post_name_remap;

                        // fill %%post_date%%
                        tmp_item = tmp_item.Replace("%%post_date%%", dt_posts.Rows[j]["postDate"].ToString());
                        // fill %%post_date_gmt%%
                        tmp_item = tmp_item.Replace("%%post_date_gmt%%", dt_posts.Rows[j]["postDateGmt"].ToString());
                        // fill %%post_name%%
                        tmp_item = tmp_item.Replace("%%post_name%%", tmp_post_name_remap);
                        
                        // add original phpbb3 url
                        if (chkShowOriginalLink.Checked)
                        {
                            tmp_content_encoded += "Convert from " + root_url + "/viewtopic.php?t=" + tmp_topic_id.ToString() + "\r\n";
                        }
                    }
                    else
                    {
                        //tmp_content_encoded += "\r\n================================\r\n";
                        if (j == addMoreTagAfterPost)
                        {
                            tmp_content_encoded += "\r\n<!--more-->";
                        }

                        tmp_content_encoded += "\r\n<hr />\r\n";
                    }

                    tmp_content_encoded += Util.AdjustTitle(dt_posts.Rows[j]["post_subject"].ToString(), forum_id) + "\r\n";
                    tmp_content_encoded += "Post by " + tmp_post_name + " >> " + dt_posts.Rows[j]["postDateGmt"].ToString() + "\r\n";
                    tmp_content_encoded += Util.AdjustContent(HttpUtility.HtmlDecode(tmp_post_text), forum_id);
                }
                tmp_item = tmp_item.Replace("%%content_encoded%%", Util.CDATA_safe(tmp_content_encoded));

                // fill %%item_post_tag%%
                string out_item_post_tag = "";
                List<string> tmp_tag_list = FindTagList(tmp_content_encoded);
                foreach (string tmp_tag_item in tmp_tag_list)
                {
                    if (dicTag.ContainsKey(tmp_tag_item.ToLower()) == false)
                    {
                        dicTag.Add(tmp_tag_item.ToLower(), tmp_tag_item);
                    }

                    if (out_item_post_tag != "")
                    {
                        out_item_post_tag += new String(' ', 8);
                    }
                    string tmp_item_post_tag = @"<category domain=""post_tag"" nicename=""%%item_post_tag_nicename%%""><![CDATA[%%item_post_tag_CDATA%%]]></category>" + "\r\n";

                    tmp_item_post_tag = tmp_item_post_tag.Replace("%%item_post_tag_nicename%%", Util.generate_slug(tmp_tag_item));
                    tmp_item_post_tag = tmp_item_post_tag.Replace("%%item_post_tag_CDATA%%", Util.CDATA_safe(tmp_tag_item));

                    out_item_post_tag += tmp_item_post_tag;
                }
                tmp_item = tmp_item.Replace("%%item_post_tag%%", out_item_post_tag);

                out_item += tmp_item;
            }
            out_content = out_content.Replace("%%item%%", out_item);

            // fill %%tag%%
            int tag_term_id = 0;
            for(int i = 0; i < dgvForumList.Rows.Count; i++)
            {
                int tmp_tag_term_id = int.Parse(dgvForumList.Rows[i].Cells["forum_id"].Value.ToString());
                if (tmp_tag_term_id > tag_term_id) { tag_term_id = tmp_tag_term_id; }
            }
            string out_tag = "";
            foreach(KeyValuePair<string, string> item in dicTag)
            {
                tag_term_id++;

                string tmp_tag = "	<wp:wp:tag><wp:term_id>%%term_id%%</wp:term_id><wp:tag_slug>%%tag_slug%%</wp:tag_slug><wp:tag_name><![CDATA[%%tag_name%%]]></wp:tag_name></wp:tag>\r\n";

                tmp_tag = tmp_tag.Replace("%%term_id%%", tag_term_id.ToString());
                tmp_tag = tmp_tag.Replace("%%tag_slug%%", Util.generate_slug(item.Value));
                tmp_tag = tmp_tag.Replace("%%tag_name%%", Util.CDATA_safe(item.Value));

                out_tag += tmp_tag;
            }
            out_content = out_content.Replace("%%tag%%", out_tag);

            // fill %%author%%
            string out_author = "";
            for (int i = 0; i < dgvUserList.Rows.Count; i++)
            {
                if (dgvUserList.Rows[i].Cells["Flag"].Value.ToString() == "*")
                {
                    string tmp_author = "	<wp:author><wp:author_id>%%author_id%%</wp:author_id><wp:author_login>%%author_login%%</wp:author_login><wp:author_email>%%author_email%%</wp:author_email><wp:author_display_name><![CDATA[%%author_display_name%%]]></wp:author_display_name><wp:author_first_name><![CDATA[]]></wp:author_first_name><wp:author_last_name><![CDATA[]]></wp:author_last_name></wp:author>\r\n";

                    tmp_author = tmp_author.Replace("%%author_id%%", dgvUserList.Rows[i].Cells["UserID"].Value.ToString());
                    tmp_author = tmp_author.Replace("%%author_login%%", dgvUserList.Rows[i].Cells["UserName"].Value.ToString());
                    tmp_author = tmp_author.Replace("%%author_email%%", dgvUserList.Rows[i].Cells["UserEMail"].Value.ToString());
                    tmp_author = tmp_author.Replace("%%author_display_name%%", dgvUserList.Rows[i].Cells["UserName"].Value.ToString());

                    out_author += tmp_author;
                }
            }
            out_content = out_content.Replace("%%author%%", out_author);

            // Write XML
            File.WriteAllText(out_full_name, out_content);

            WriteLog("End");
        }

        string ConvertBBCode(string content, string bbcode_uid)
        {
            string rtn = content;

            //lstUnmappedBBCode.Items.Clear();

            List<string> lstBBCode = FindBBCode(content, bbcode_uid);
            foreach (string item in lstBBCode)
            {
                string htmlTag = ConvertBBCodeToHtmlTag(item, bbcode_uid);

                if (item == htmlTag)
                {
                    lstUnmappedBBCode.Items.Add(item);
                    continue;
                }

                content = content.Replace(item, htmlTag);
            }

            content = Util.AdjustBBCode(content);

            return content;
        }

        string ConvertBBCodeToHtmlTag(string bbcode, string bbcode_uid)
        {
            string rtn = bbcode;

            // Build BBCdoe to Html Tag dictionary
            BuildBBCodeToHtmlTagDictionary();
            
            // BBCode match
            foreach(KeyValuePair<string, string> item in dicBBCodePattern)
            {
                bool findBBCodeFlag = false;
                
                for (int i = 0; i < 2; i++)
                {
                    string tmp_pattern = item.Value;

                    if (i == 0) { tmp_pattern = tmp_pattern.Replace("%%bbcode_uid%%", bbcode_uid); } // with bbcode_uid
                    if (i == 1) { tmp_pattern = tmp_pattern.Replace(":%%bbcode_uid%%", ""); } // without bbcode_uid
                    
                    Regex rgx = new Regex(tmp_pattern);
                    Match m = rgx.Match(bbcode);
                    if (m.Success == false) { continue; }

                    rtn = dicBBCodeHtmlTag[item.Key].ToString();
                    
                    string[] grpNames = rgx.GetGroupNames();
                    for(int j = 1; j < grpNames.Length; j++)
                    {
                        rtn = rtn.Replace("%%" + grpNames[j] + "%%", m.Groups[grpNames[j]].ToString());
                    }
                    
                    findBBCodeFlag = true;
                    break;
                }
                
                if (findBBCodeFlag) { break; }
            }

            return rtn;
        }

        void BuildBBCodeToHtmlTagDictionary()
        {
            if (dicBBCodeHtmlTag.Count > 0) { return; }
            if (txtBBCodeToHtmlTag.Text == "") { return; }

            string[] aryBBCode = txtBBCodeToHtmlTag.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < aryBBCode.Length; i++)
            {
                int idx = aryBBCode[i].IndexOf("]=");
                if (idx == -1) { continue; }

                string tmp_bbcode = aryBBCode[i].Substring(0, idx + 1);
                string tmp_htmltag = aryBBCode[i].Substring(idx + 2);

                if (dicBBCodeHtmlTag.ContainsKey(tmp_bbcode)) { continue; }

                dicBBCodeHtmlTag.Add(tmp_bbcode, tmp_htmltag);

                // Pattern
                string tmp_pattern = tmp_bbcode.Substring(0, tmp_bbcode.Length - 1) + ":%%bbcode_uid%%]";
                tmp_pattern = tmp_pattern.Replace("[", @"\[").Replace("]", @"\]").Replace("*", @"\*");
                tmp_pattern = tmp_pattern.Replace("%%TEXT1%%", "(?<TEXT1>.+)");
                tmp_pattern = tmp_pattern.Replace("%%TEXT2%%", "(?<TEXT2>.+)");

                dicBBCodePattern.Add(tmp_bbcode, tmp_pattern);
            }
        }

        List<string> FindBBCode(string content, string bbcode_uid)
        {
            // Build BBCdoe to Html Tag dictionary
            BuildBBCodeToHtmlTagDictionary();
            
            List<string> rtn = new List<string>();

            // find BBCode with bbcode_uid
            string splitPattern = ":" + bbcode_uid + "]";
            string[] aryBBCode = content.Split(new string[] { splitPattern }, StringSplitOptions.None);

            int cnt = (content.Length - content.Replace(splitPattern, "").Length) / splitPattern.Length;

            for (int i = 0; i < cnt; i++)
            {
                int idx = aryBBCode[i].LastIndexOf("[");

                if (idx == -1) { continue; }
                rtn.Add(aryBBCode[i].Substring(idx) + splitPattern);
            }

            // find BBCode without bbcode_uid by dicBBCodePattern
            foreach(KeyValuePair<string, string> item in dicBBCodePattern)
            {
                string tmp_pattern = item.Value;

                tmp_pattern = tmp_pattern.Replace(":%%bbcode_uid%%", ""); // without bbcode_uid

                Regex rgx = new Regex(tmp_pattern);
                Match m = rgx.Match(content);
                while (m.Success)
                {
                    string bbcode = m.Value;

                    rtn.Add(bbcode);

                    m = m.NextMatch();
                }
            }

            return rtn;
        }

        string PosterRemap(string poster_orig)
        {
            string rtn = poster_orig;

            if (rtn == "") { return rtn; }
            if (rdoP2ANone.Checked) { return rtn; }

            // generate Poster re-mapping to Auther array
            if (aryP2A == null)
            {
                aryP2A = txtP2AReMapping.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < aryP2A.Length; i++)
                {
                    // "auth1=poster11,post12" re-format to ",auth1,poster11,post12,"
                    aryP2A[i] = aryP2A[i].Replace(" ", "").Replace("=", ",");
                    aryP2A[i] = "," + aryP2A[i] + ",";
                    aryP2A[i] = Regex.Replace(aryP2A[i], ",+", ",");
                }
            }

            // poseter re-mapping
            if (chkP2AReMapping.Checked)
            {
                for (int i =0; i < aryP2A.Length; i++)
                {
                    if (aryP2A[i].IndexOf("," + rtn + ",") >= 0) // find re-mapping poster
                    {
                        int idx2 = aryP2A[i].IndexOf(",", 1); // get the second ,
                        if (idx2 >= 0)
                        {
                            rtn = aryP2A[i].Substring(1, idx2 - 1);
                            return rtn;
                        }
                    }
                }
            }

            // poster default
            if (chkP2ADefault.Checked)
            {
                if (txtP2ADefault.Text.Trim() != "")
                {
                    rtn = txtP2ADefault.Text.Trim();
                }
            }

            return rtn;
        }
        
        List<string> FindTagList(string content)
        {
            List<string> rtn = new List<string>();
            string tmp_content = content.ToLower();

            // generate TagList to Tag array
            if (aryTag == null || aryTag.Length == 0)
            {
                aryTag = txtTagList.Text.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < aryTag.Length; i++)
                {
                    aryTag[i] = aryTag[i].Trim();
                }
            }

            // find tag
            for (int i = 0; i < aryTag.Length; i++)
            {
                if (aryTag[i] == "") { continue; }

                if (tmp_content.IndexOf(aryTag[i].ToLower()) != -1)
                {
                    rtn.Add(aryTag[i]);
                }
            }
            
            return rtn;
        }

        DataTable GetTopicByForumID(int forum_id)
        {
            DataTable rtn = new DataTable();

            string connStr = txtMySQLphpbb3ConnStr.Text;

            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();

                cmd = new MySqlCommand();
                cmd.Connection = conn;

                string sql = @"
select t1.topic_title
  , t1.topic_id
  , from_unixtime(t1.topic_time, '%a, %d %b %Y %H:%i:%S +0000') as pubDate
  , t2.username
from  " + txtTablePrefix.Text + @"topics as t1
join  " + txtTablePrefix.Text + @"users as t2 on t2.user_id = t1.topic_poster
where forum_id = @forum_id
order by t1.topic_id
;";

                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@forum_id", forum_id);

                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

                adp.Fill(rtn);

                cmd.Dispose();
                conn.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return rtn;
        }

        DataTable GetPostByTopicID(int topic_id)
        {
            DataTable rtn = new DataTable();

            string connStr = txtMySQLphpbb3ConnStr.Text;

            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();

                cmd = new MySqlCommand();
                cmd.Connection = conn;

                string sql = @"
SELECT t1.post_subject
  , t1.post_text
  , ifnull(t2.username, t1.post_username) as post_username
  , from_unixtime(t1.post_time, '%Y-%m-%d, %H:%i:%S') as postDate
  , from_unixtime(t1.post_time, '%Y-%m-%d, %H:%i:%S') as postDateGmt
  , t1.bbcode_uid
from " + txtTablePrefix.Text + @"posts as t1
left join " + txtTablePrefix.Text + @"users as t2 on t1.poster_id = t2.user_id
where t1.topic_id = @topic_id
and t1.post_visibility = 1
order by t1.post_time
;";

                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@topic_id", topic_id);

                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);

                adp.Fill(rtn);

                cmd.Dispose();
                conn.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return rtn;
        }

        string GetConfigValue(string config_name)
        {
            string rtn = "";
            string connStr = txtMySQLphpbb3ConnStr.Text;

            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();

                cmd = new MySqlCommand();
                cmd.Connection = conn;

                string sql = @"
SELECT t1.config_value
from " + txtTablePrefix.Text + @"config as t1
where t1.config_name = @config_name
;";

                cmd.CommandText = sql;
                cmd.Parameters.AddWithValue("@config_name", config_name);

                rtn = cmd.ExecuteScalar().ToString();

                cmd.Dispose();
                conn.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return rtn;
        }

        private void chkP2ADefault_CheckedChanged(object sender, EventArgs e)
        {
            rdoP2ANone.Checked = false;
        }

        private void chkP2AReMapping_CheckedChanged(object sender, EventArgs e)
        {
            rdoP2ANone.Checked = false;
        }

        private void rdoP2ANone_CheckedChanged(object sender, EventArgs e)
        {
            chkP2ADefault.Checked = false;
            chkP2AReMapping.Checked = false;
        }

        void WriteLog(string msg)
        {
            try
            {
                string file = Application.StartupPath + @"\" + DateTime.Now.ToString("yyyyMMdd") + ".log";

                using (StreamWriter sw = new StreamWriter(file, true))
                {
                    sw.WriteLine(DateTime.Now.ToString("yyyyMMdd HHmmss: ") + msg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("WriteLog Message=" + ex.Message);
            }
        }

    }
}
