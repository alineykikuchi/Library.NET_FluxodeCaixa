using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
public class DataValueAttribute : Attribute
{

    private List<string> _Value;
    public List<string> Value
    {
        get { return _Value; }
    }

    public DataValueAttribute(params string[] Valores)
    {
        this._Value = new List<string>();

        foreach (string Valor in Valores)
        {
            this._Value.Add(Valor);
        }

    }

}