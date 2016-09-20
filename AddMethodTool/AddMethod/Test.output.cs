// Copyright (c) AlphaSierraPapa for the SharpDevelop Team
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of this
// software and associated documentation files (the "Software"), to deal in the Software
// without restriction, including without limitation the rights to use, copy, modify, merge,
// publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons
// to whom the Software is furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all copies or
// substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED,
// INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR
// PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE
// FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
// OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
// DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;

namespace AddMethod
{
	/// <summary>
	/// This class contains various IndexOf calls.
	/// Only the ones in the first should be detected as missing a StringComparison.
	/// </summary>
	public class Test
	{
		public void StringIndexOfStringCalls(List<string> list)
		{

if (FixUtil.Instance.NeedFix("Test.StringIndexOfStringCalls"))
{
    string strParameter = string.Format("Test,StringIndexOfStringCalls,{0},{1}", typeof(object), typeof(List<string>));
    FixUtil.Instance.Fix(strParameter, this, list);
    return;
}

			list[0].IndexOf(".com");
			list[0].IndexOf(".com", 0);
			list[0].IndexOf(".com", 0, 5);
			list[0].IndexOf(list[1], 0, 10);
		}
		
		public void StringIndexOfStringCallsWithComparison(List<string> list)
		{

if (FixUtil.Instance.NeedFix("Test.StringIndexOfStringCallsWithComparison"))
{
    string strParameter = string.Format("Test,StringIndexOfStringCallsWithComparison,{0},{1}", typeof(object), typeof(List<string>));
    FixUtil.Instance.Fix(strParameter, this, list);
    return;
}

			list[0].IndexOf(".com", StringComparison.OrdinalIgnoreCase);
			list[0].IndexOf(".com", 0, StringComparison.OrdinalIgnoreCase);
			list[0].IndexOf(".com", 0, 5, StringComparison.OrdinalIgnoreCase);
			list[0].IndexOf(list[1], 0, 10, StringComparison.OrdinalIgnoreCase);
		}
		
		public void StringIndexOfCharCalls(List<string> list)
		{

if (FixUtil.Instance.NeedFix("Test.StringIndexOfCharCalls"))
{
    string strParameter = string.Format("Test,StringIndexOfCharCalls,{0},{1}", typeof(object), typeof(List<string>));
    FixUtil.Instance.Fix(strParameter, this, list);
    return;
}

			list[0].IndexOf('.');
			Environment.CommandLine.IndexOf('/');
		}
		
		public void OtherIndexOfCalls(List<string> list)
		{

if (FixUtil.Instance.NeedFix("Test.OtherIndexOfCalls"))
{
    string strParameter = string.Format("Test,OtherIndexOfCalls,{0},{1}", typeof(object), typeof(List<string>));
    FixUtil.Instance.Fix(strParameter, this, list);
    return;
}

			list.IndexOf(".com");
		}



        public void SetName(string name)
        {

if (FixUtil.Instance.NeedFix("Test.SetName"))
{
    string strParameter = string.Format("Test,SetName,{0},{1}", typeof(object), typeof(string));
    FixUtil.Instance.Fix(strParameter, this, name);
    return;
}


        }
        public void SetTime()
        {

if (FixUtil.Instance.NeedFix("Test.SetTime"))
{
    string strParameter = string.Format("Test,SetTime,{0}", typeof(object));
    FixUtil.Instance.Fix(strParameter, this);
    return;
}


        }
        public static void SetNameStatic(string name)
        {

if (FixUtil.Instance.NeedFix("Test.SetNameStatic"))
{
    string strParameter = string.Format("Test,SetNameStatic,{0},{1}", typeof(object), typeof(string));
    FixUtil.Instance.Fix(strParameter, null, name);
    return;
}


        }
        public static void SetTimeStatic()
        {

if (FixUtil.Instance.NeedFix("Test.SetTimeStatic"))
{
    string strParameter = string.Format("Test,SetTimeStatic,{0}", typeof(object));
    FixUtil.Instance.Fix(strParameter, null);
    return;
}


        }
	}
}
