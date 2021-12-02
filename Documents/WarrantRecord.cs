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
        /// Главный инженер проекта
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
        /// <param name="tomeCipher">Шифр тома</param>
        /// <param name="documentName">Наименование документа</param>
        /// <param name="stage">Стадия</param>
        /// <param name="companyName">Название компании</param>
        /// <param name="mainIngenerName">Главный инженер, (руководитель проекта) имя</param>
        /// <param name="mainIngenerName">Главный инженер, (руководитель проекта) фамилия</param>
        /// <param name="mainIngenerName">Главный инженер, (руководитель проекта) отчество</param>
        public WarrantRecord(string developerName, string whoChecked, string normalInspection, string tomeCipher, string documentName, string stage, string companyName, Entities.Person mainIngener)
        {
            DeveloperName = developerName;
            WhoChecked = whoChecked;
            NormalInspection = normalInspection;
            GIP = "\""+mainIngener.Surname+"\"";
            TomeCipher = tomeCipher;
            DocumentName = documentName;
            Stage = stage;
            CompanyName = companyName;
            MainIngenerName = mainIngener.Name[0] + ". " + mainIngener.Patronymic[0] + ". " + mainIngener.Surname;
        }
    }
}