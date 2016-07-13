﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SCSM.AzureAutomation.WPF.Helpers
{
    public class ObjectHelpers
    {
        public List<string> GetPropertiesNameOfClass(object pObject)
        {
            List<string> propertyList = new List<string>();
            if (pObject != null)
            {
                foreach (var prop in pObject.GetType().GetProperties())
                {
                    propertyList.Add(prop.Name);
                }
            }
            return propertyList;
        }
    }
}
