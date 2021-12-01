using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASO.Documents
{
    public class WarrantRecord
    {
        public string DeveloperName { get; private set; }
        public string WhoChecked { get; private set; }
        public string ContrName { get; private set; }
        public string GIP { get; private set; }
        public string TomeCipher { get; private set; }
        public string DocumentName { get; private set; }
        public string Stage { get; private set; }
        public string CompanyName { get; private set; }
        public string MainIngenerName { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="developerName">Разработал</param>
        /// <param name="whoChecked">Проверил</param>
        /// <param name="contrName"></param>
        /// <param name="gip"></param>
        /// <param name="tomeCipher"></param>
        /// <param name="documentName"></param>
        /// <param name="stage"></param>
        /// <param name="compantName"></param>
        /// <param name="mainIngenerName"></param>
        public WarrantRecord(string developerName, string whoChecked, string contrName, string gip, string tomeCipher, string documentName, string stage, string compantName, string mainIngenerName)
        {
            DeveloperName = developerName;
            WhoChecked = whoChecked;
            ContrName = contrName;
            GIP = gip;
            TomeCipher = tomeCipher;
            DocumentName = documentName;
            Stage = stage;
            CompanyName = compantName;
            MainIngenerName = mainIngenerName;
        }
    }
}
