﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

using Framework.Main;

namespace WindowsFormsMapEditor
{
    public delegate void Action();
    public delegate void Action<T1, T2>(T1 t1, T2 t2);

    [Serializable]
    public struct Tuple<T1, T2> { public T1 first; public T2 second; public Tuple(T1 one, T2 two) { first = one; second = two; } }
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(ResolveAssembly);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainGame mainGame = MainGame.GetT;
            //Application.Run(new Main());
            using (Main mainForm = new Main())
            {
                mainGame.Init();
                mainForm.Show();
                while (mainForm.Created)
                {
                    mainForm.UtilityUpdate();
                    mainGame.Update();
                    mainGame.Render();
                    System.Threading.Thread.Sleep(10);
                    Application.DoEvents();
                }
            }
        }

        static Assembly ResolveAssembly(object sender, ResolveEventArgs args)
        {
            Assembly thisAssembly = Assembly.GetExecutingAssembly();
            string resourceName = null;
            string fileName = args.Name.Substring(0, args.Name.IndexOf(',')) + ".dll";
            foreach (string name in thisAssembly.GetManifestResourceNames())
            {
                if (name.EndsWith(fileName))
                {
                    resourceName = name;
                }
            }

            if (resourceName != null)
            {
                using (Stream stream = thisAssembly.GetManifestResourceStream(resourceName))
                {
                    if (stream != null)
                    {
                        byte[] assembly = new byte[stream.Length];
                        stream.Read(assembly, 0, assembly.Length);
                        Console.WriteLine("Dll file load : " + resourceName);
                        return Assembly.Load(assembly);
                    }
                }
            }
            return null;
        }
    }
}
