﻿/*
 * Copyright 2016 Mikhail Shiryaev
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Product  : Rapid SCADA
 * Module   : ScadaWebCommon
 * Summary  : Web application settings
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2011
 * Modified : 2016
 */

using System.Collections.Generic;

namespace Scada.Web
{
    /// <summary>
    /// Web application settings
    /// <para>Настройки веб-приложения</para>
    /// </summary>
    public class WebSettings : ISettings
    {
        /// <summary>
        /// Имя файла настроек по умолчанию
        /// </summary>
        public const string DefFileName = "WebSettings.xml";

        
        /// <summary>
        /// Конструктор
        /// </summary>
        public WebSettings()
        {
            PluginFileNames = new List<string>();
            SetToDefault();
        }


        /// <summary>
        /// Получить список имён файлов библиотек подключенных плагинов
        /// </summary>
        public List<string> PluginFileNames { get; protected set; }


        /// <summary>
        /// Установить значения настроек по умолчанию
        /// </summary>
        protected void SetToDefault()
        {
            PluginFileNames.Clear();
        }


        /// <summary>
        /// Создать новый объект настроек
        /// </summary>
        public ISettings Create()
        {
            return new WebSettings();
        }

        /// <summary>
        /// Определить, равны ли заданные настройки текущим настройкам
        /// </summary>
        public bool Equals(ISettings settings)
        {
            return settings == this;
        }

        /// <summary>
        /// Загрузить настройки из файла
        /// </summary>
        public bool LoadFromFile(string fileName, out string errMsg)
        {
            SetToDefault();
            PluginFileNames.Add("PlgTableView.dll");
            PluginFileNames.Add("PlgSchemeView.dll");
            errMsg = "";
            return true;
        }

        /// <summary>
        /// Сохранить настройки в файле
        /// </summary>
        public bool SaveToFile(string fileName, out string errMsg)
        {
            errMsg = "WebSettings not implemented";
            return false;
        }
    }
}
