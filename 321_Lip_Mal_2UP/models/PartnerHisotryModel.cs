﻿using _321_Lip_Mal_2UP.utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _321_Lip_Mal_2UP.models
{
    public class PartnerHisotryModel
    {
        // создаем список продуктов которые продавал выбранный партнер
        public List<ProductHistory> products;

        // создаем айди партнера для которого нужно получить информацию
        private int partnerID;

        public PartnerHisotryModel(int partnerid)
        {
            // получаем айди
            partnerID = partnerid;
            // инициализируем данные
            products = fillProducts();
        }

        // метод получения имени партнера по айди
        public string getPartnerNameByID()
        {
            return DbManager.getPartnerByID(partnerID).PartnerName;
        }

        // метод заполнения продуктов выбранного партнера
        private List<ProductHistory> fillProducts()
        {
            return DbManager.getProductsHistoryByPartnerID(partnerID);
        }
    }
}
