using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASO.Documents
{
    public class WarrantRecord
    {
        /// <summary>
        /// Разработал
        /// </summary>
        public string DeveloperName { get; private set; }
        /// <summary>
        /// Проверил
        /// </summary>
        public string WhoChecked { get; private set; }
        /// <summary>
        /// Нормоконтроль
        /// </summary>
        public string NormalInspection { get; private set; }
        /// <summary>
        /// ГИП
        /// </summary>
        public string GIP { get; private set; }
        /// <summary>
        /// «Шифр тома»-ТЧ
        /// </summary>
        public string TomeCipher { get; private set; }
        /// <summary>
        /// Название документа
        /// </summary>
        public string DocumentName { get; private set; }
        /// <summary>
        /// Стадия
        /// </summary>
        public string Stage { get; private set; }
        /// <summary>
        /// Название компании
        /// </summary>
        public string CompanyName { get; private set; }
        /// <summary>
        /// Главный инженер, фамилия и инициалы (И.О. Фамилия РП)
        /// </summary>
        public string MainIngenerName { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="developerName">Разработал</param>
        /// <param name="whoChecked">Проверил</param>
        /// <param name="normalInspection">Нормоконтроллер</param>
        /// <param name="gip">ГИП</param>
        /// <param name="tomeCipher">Шифр тома</param>
        /// <param name="documentName">Наименование документа</param>
        /// <param name="stage">Стадия</param>
        /// <param name="companyName">Название компании</param>
        /// <param name="mainIngenerName">Главный инженер, (руководитель проекта) имя</param>
        /// <param name="mainIngenerName">Главный инженер, (руководитель проекта) фамилия</param>
        /// <param name="mainIngenerName">Главный инженер, (руководитель проекта) отчество</param>
        public WarrantRecord(string developerName, string whoChecked, string normalInspection, string gip, string tomeCipher, string documentName, string stage, string companyName, string mainIngenerName, string mainIngenerSurname, string mainIngenerPatronymic)
        {
            DeveloperName = developerName;
            WhoChecked = whoChecked;
            NormalInspection = normalInspection;
            GIP = gip;
            TomeCipher = tomeCipher;
            DocumentName = documentName;
            Stage = stage;
            CompanyName = companyName;
            MainIngenerName = mainIngenerName[0] + ". " + mainIngenerPatronymic[0] + ". " + mainIngenerName;
        }
    }
}