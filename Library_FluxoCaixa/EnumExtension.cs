using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;

namespace Library_FluxoCaixa
{
    public class EnumExtension
    {
        //public static string GetDescription(System.Enum value)
        //{
        //    FieldInfo fi = value.GetType().GetField(value.ToString());
        //    DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);
        //    if (attributes.Length > 0)
        //    {
        //        return attributes[0].Description;
        //    }
        //    else
        //    {
        //        return value.ToString();
        //    }
        //}
        public static List<string> GetDatavalues(System.Enum theEnum)
        {
            List<string> lstRetorno = null;
            FieldInfo enumField;
            object[] arrAtributes;

            enumField = theEnum.GetType().GetField(theEnum.ToString());

            arrAtributes = enumField.GetCustomAttributes(typeof(DataValueAttribute), false);

            if (arrAtributes.Length > 0)
            {
                lstRetorno = new List<string>();
                foreach (string attrValor in arrAtributes)
                {
                    lstRetorno.Add(attrValor);
                }
            }

            return lstRetorno;
        }

        public static string GetDatavalue(System.Enum Valor)
        {
            List<string> lstValues;

            lstValues = GetDatavalues(Valor);

            if (lstValues != null)
            {
                if (lstValues.Count > 0)
                {
                    return lstValues[0];
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
