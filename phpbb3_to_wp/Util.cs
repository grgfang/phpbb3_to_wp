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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace phpbb3_to_wp
{
    public static partial class Util
    {
        public static string CDATA_safe(string cdata)
        {
            return cdata.Replace("]]>", "] ]>");
        }

        public static string generate_slug(string in_string)
        {
            // reference formatting.php and wordrpess export xml file

            string rtn = in_string;
            
            // replace entity name to space
            // add more needed
            // ref: HTML ANSI (Windows-1252) Reference
            // http://www.w3schools.com/charsets/ref_html_ansi.asp
            string[] aryEntity = new string[] { "&quot;", "&amp;", "&lt;", "&gt;", "&euro;"
                                              , "&sbquo;", "&fnof;", "&bdquo;", "&hellip;", "&dagger;"
                                              , "&Dagger;", "&circ;", "&permil;", "&Scaron;", "&lsaquo;"
                                              , "&OElig;", "&Zcaron;", "&lsquo;", "&rsquo;", "&ldquo;"
                                              , "&rdquo;", "&bull;", "&ndash;", "&mdash;", "&tilde;"
                                              , "&trade;", "&scaron;", "&rsaquo;", "&oelig;", "&zcaron;"
                                              , "&Yuml;", "&nbsp;", "&iexcl;", "&cent;", "&pound;"
                                              , "&curren;", "&yen;", "&brvbar;", "&sect;", "&uml;"
                                              , "&copy;", "&ordf;", "&laquo;", "&not;", "&shy;"
                                              , "&reg;", "&macr;", "&deg;", "&plusmn;", "&sup2;"
                                              , "&sup3;", "&acute;", "&micro;", "&para;", "&middot;"
                                              , "&cedil;", "&sup1;", "&ordm;", "&raquo;", "&frac14;"
                                              , "&frac12;", "&frac34;", "&iquest;", "&Agrave;", "&Aacute;"
                                              , "&Acirc;", "&Atilde;", "&Auml;", "&Aring;", "&AElig;"
                                              , "&Ccedil;", "&Egrave;", "&Eacute;", "&Ecirc;", "&Euml;"
                                              , "&Igrave;", "&Iacute;", "&Icirc;", "&Iuml;", "&ETH;"
                                              , "&Ntilde;", "&Ograve;", "&Oacute;", "&Ocirc;", "&Otilde;"
                                              , "&Ouml;", "&times;", "&Oslash;", "&Ugrave;", "&Uacute;"
                                              , "&Ucirc;", "&Uuml;", "&Yacute;", "&THORN;", "&szlig;"
                                              , "&agrave;", "&aacute;", "&acirc;", "&atilde;", "&auml;"
                                              , "&aring;", "&aelig;", "&ccedil;", "&egrave;", "&eacute;"
                                              , "&ecirc;", "&euml;", "&igrave;", "&iacute;", "&icirc;"
                                              , "&iuml;", "&eth;", "&ntilde;", "&ograve;", "&oacute;"
                                              , "&ocirc;", "&otilde;", "&ouml;", "&divide;", "&oslash;"
                                              , "&ugrave;", "&uacute;", "&ucirc;", "&uuml;", "&yacute;"
                                              , "&thorn;", "&yuml;"            
                                              };
            for (int i = 0; i < aryEntity.Length; i++)
            {
                rtn = rtn.Replace(aryEntity[i], " ");
            }

            // HtmlDecode avoid unknown entity name
            rtn = HttpUtility.HtmlDecode(rtn);

            // replace symbol to space
            // add more needed
            // ref: URLEncode Code Chart
            // http://www.backbone.se/urlencodingUTF8.htm
            // !"#$%&'()*+,-./:;<=>?@[\]^_`{|}~€‚ƒ„…†‡ˆ‰Š‹ŒŽ‘’“”•–—˜™š›œžŸ¡¢£¤¥¦§¨©ª«¬¯®¯°±²³´µ¶·¸¹º»¼½¾¿ÀÁÂÃÄÅÆÇÈÉÊËÌÍÎÏÐÑÒÓÔÕÖ×ØÙÚÛÜÝÞßàáâãäåæçèéêëìíîïðñòóôõö÷øùúûüýþÿ
            string[,] Symbol_Set = new string[,] { {" ", "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~€‚ƒ„…†‡ˆ‰‹‘’“”•–—˜™›¡¢£¤¥¦§¨©ª«¬¯®¯°±²³´µ¶·¸¹º»¼½¾¿×Øß÷"}
                                                 , {"A", "ÀÁÂÃÄÅ"}
                                                 , {"a", "àáâãäå"}
                                                 , {"C", "Ç"}
                                                 , {"c", "ç"}
                                                 , {"D", "Ð"}
                                                 , {"d", "ð"}
                                                 , {"E", "ÈÉÊË"}
                                                 , {"e", "èéêë"}
                                                 , {"I", "ÌÍÎÏ"}
                                                 , {"i", "ìíîï"}
                                                 , {"N", "Ñ"}
                                                 , {"n", "ñ"}
                                                 , {"O", "ÒÓÔÕÖ"}
                                                 , {"o", "òóôõöø"}
                                                 , {"S", "Š"}
                                                 , {"s", "š"}
                                                 , {"U", "ÙÚÛÜ"}
                                                 , {"u", "ùúûü"}
                                                 , {"Y", "ŸÝ"}
                                                 , {"y", "ýÿ"}
                                                 , {"Z", "Ž"}
                                                 , {"z", "ž"}
                                                 , {"AE", "Æ"}
                                                 , {"ae", "æ"}
                                                 , {"CE", "Œ"}
                                                 , {"ce", "œ"}
                                                 , {"TH", "Þ"}
                                                 , {"th", "þ"}
                                                 };
            for (int i = 0; i < Symbol_Set.GetLength(0); i++)
            {
                for (int j = 0; j < Symbol_Set[i, 1].Length; j++)
                {
                    rtn = rtn.Replace(Symbol_Set[i, 1].Substring(j, 1), Symbol_Set[i, 0]);
                }
            }

            // replace more whitespace to hyphen(-)
            rtn = Regex.Replace(rtn, @"\s+", "-");

            // lower case
            rtn = rtn.ToLower();

            // encode
            rtn = HttpUtility.UrlEncode(rtn);

            return rtn;
        }

        public static string AdjustTitle(string title, int forum_id)
        {
            return AdjustTitleExtra(title, forum_id);
        }

        public static string AdjustContent(string content, int forum_id)
        {
            return AdjustContentExtra(content, forum_id);
        }

        public static string AdjustBBCode(string content)
        {
            Regex rgx;
            Match m;
            // [url]%%href%%[/url] -> <a>%%href%%</a> -> <a href="%%href%%">%%href%%</a>
            rgx = new Regex("<a>(?<href>.+)</a>");
            m = rgx.Match(content);
            while (m.Success)
            {
                string[] arySplit = m.Value.Split(new char[] { ' ' });
                for (int i = 0; i < arySplit.Length; i++)
                {
                    string href = arySplit[i].Replace("<a>", "").Replace("</a>", "");

                    content = content.Replace(arySplit[i]
                    , "<a href=\"" + href + "\">" + href + "</a>");
                }

                m = m.NextMatch();
            }

            // [img]%%src%%[/img] -> <img>%%src%%</img> -> <img src="%%src%%" />
            rgx = new Regex("<img>(?<src>.+)</img>");
            m = rgx.Match(content);
            while (m.Success)
            {
                string[] arySplit = m.Value.Split(new char[] { ' ' });
                for (int i = 0; i < arySplit.Length; i++)
                {
                    string src = arySplit[i].Replace("<img>", "").Replace("</img>", "");

                    content = content.Replace(arySplit[i]
                    , "<img src=\"" + src + "\" />");
                }

                m = m.NextMatch();
            }

            return AdjustBBCodeExtra(content);
        }

    }
}
