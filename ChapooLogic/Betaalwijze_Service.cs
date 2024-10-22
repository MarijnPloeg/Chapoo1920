﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChapooDAL;
using ChapooModel;

namespace ChapooLogic
{
    public class Betaalwijze_Service
    {
        Betaalwijze_DAO betaalwijze_db = new Betaalwijze_DAO();
        public List<Betaling> GetBetalingen()
        {
            try
            {
                List<Betaling> betaalwijzes = betaalwijze_db.DB_Get_All_Betaalwijze();
                return betaalwijzes;
            }
            catch (Exception)
            {
                MessageBox.Show("Kan geen contact maken met de database");
                throw new Exception("Kan geen contact maken met de database");
            }

        }
    }
}
