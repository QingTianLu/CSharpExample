﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace TestOracleConnection
{
    class Program
    {
        //需要测试该代码，只要改动sql语句和连接数据库字符串即可。
        static void Main(string[] args)
        {
            //object result = OracleDataProvider.TestReadTable("110");
            DataTable result = OracleDataProvider.TestReadTable("110");
            for (int i = 0; i < result.Rows.Count; i++)
            {
                Console.WriteLine(result.Rows[i]["BOOKNAME"].ToString());
            }

            Console.Read();
            Console.WriteLine();
        }
    }
}
