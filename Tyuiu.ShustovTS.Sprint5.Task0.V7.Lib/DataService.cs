﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.ShustovTS.Sprint5.Task0.V7.Lib
{
    public class DataService : ISprint5Task0V7
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double res = Math.Round(-(Math.Pow(x, 3)) + 4 * Math.Pow(x, 2) - (3 / 2) * x, 3);
            File.WriteAllText(path, Convert.ToString(res));
            return path;
        }
    }
}
