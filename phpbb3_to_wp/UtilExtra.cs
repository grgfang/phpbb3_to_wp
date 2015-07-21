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
using System.IO;
using System.Windows.Forms;

namespace phpbb3_to_wp
{
    public static partial class Util
    {
        /// <summary>
        /// Posts title made special adjustments for your phpbb3
        /// </summary>
        /// <param name="title"></param>
        /// <param name="forum_id"></param>
        /// <returns></returns>
        public static string AdjustTitleExtra(string title, int forum_id)
        {
            return title;
        }

        /// <summary>
        /// Posts content made special adjustments for your phpbb3
        /// </summary>
        /// <param name="content"></param>
        /// <param name="forum_id"></param>
        /// <returns></returns>
        public static string AdjustContentExtra(string content, int forum_id)
        {
            return content;
        }

        /// <summary>
        /// Posts BBCode made special adjustments for your phpbb3
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        public static string AdjustBBCodeExtra(string content)
        {
            return content;
        }

    }
}
