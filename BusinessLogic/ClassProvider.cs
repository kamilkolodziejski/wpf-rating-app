using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Kolodziejski.RatingApp.BusinessLogic.Properties;
using Kolodziejski.RatingApp.Interfaces;

namespace Kolodziejski.RatingApp.BusinessLogic
{
    class ClassProvider
    {
        public IBookRepository GetBookRepositoryImplementation()
        {
            var dllName = Settings.Default.DllRepository;
            var dllFile = new FileInfo($@"../../../Libraries/{dllName}");
            Assembly assembly = Assembly.UnsafeLoadFrom(dllFile.FullName);
            var types = assembly.GetTypes();
            foreach (var type in types)
            {
                if (type.GetInterface("Kolodziejski.RatingApp.Interfaces.IBookRepository") != null)
                {
                    return (IBookRepository)Activator.CreateInstance(type, null);
                }
            }
            return null;
        }
    }
}
