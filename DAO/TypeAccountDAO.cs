﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class TypeAccountDAO
    {
        private static TypeAccountDAO instance;

        public static TypeAccountDAO Instance
        {
            get { if (instance == null) instance = new TypeAccountDAO(); return instance; }
            private set { instance = value; }
        }
        private TypeAccountDAO() { }
        public List<string> GetListTypeName()
        {
            List<string> list = new List<string>();
            //code
            return list;
        }
        public List<TypeAccount> GetListType()
        {
            List<TypeAccount> list = new List<TypeAccount>();
            //code
            return list;
        }
    }
}
