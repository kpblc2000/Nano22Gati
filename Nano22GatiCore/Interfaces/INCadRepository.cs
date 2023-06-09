using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Nano22GatiCore.Interfaces
{
    public interface INCadRepository
    {
        /// <summary>
        /// Проверяет, активен ли документ
        /// </summary>
        bool IsDocumentActive { get; }
        /// <summary>
        /// Получение полного имени файла
        /// </summary>
        string DrawingName { get; }
        /// <summary>
        /// Получение перечня имен слоев текущего документа
        /// </summary>
        /// <returns></returns>
        List<string> GetLayerNamesList();

        void ShowModalWindow(Window win);
    }
}
