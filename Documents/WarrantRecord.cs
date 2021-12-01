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
        /// <param name="contrName">Н. Контр.</param>
        /// <param name="gip">ГИП</param>
        /// <param name="tomeCipher">Шифр тома</param>
        /// <param name="documentName">Наименование документа</param>
        /// <param name="stage">Стадия</param>
        /// <param name="companyName">Название компании</param>
        /// <param name="mainIngenerName">Главный инженер, фамилия и инициалы</param>
        public WarrantRecord(string developerName, string whoChecked, string contrName, string gip, string tomeCipher, string documentName, string stage, string companyName, string mainIngenerName)
        {
            DeveloperName = developerName;
            WhoChecked = whoChecked;
            ContrName = contrName;
            GIP = gip;
            TomeCipher = tomeCipher;
            DocumentName = documentName;
            Stage = stage;
            CompanyName = companyName;
            MainIngenerName = mainIngenerName;
        }
    }
}
