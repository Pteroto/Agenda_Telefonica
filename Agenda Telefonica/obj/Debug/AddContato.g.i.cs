﻿#pragma checksum "C:\Users\gustavo.monteiro\Documents\Visual Studio 2012\Projects\agenda_telefonica\Agenda Telefonica\AddContato.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "917B9B37F0F7AF5CCAF6D58F7E41CB9D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Agenda_Telefonica {
    
    
    public partial class AddContato : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.DataTemplate lpkItemTemplate;
        
        internal System.Windows.DataTemplate lpkFullItemTemplate;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.StackPanel NomePanel;
        
        internal System.Windows.Controls.TextBlock lblNome;
        
        internal System.Windows.Controls.TextBox txtNome;
        
        internal System.Windows.Controls.StackPanel NumeroPanel;
        
        internal System.Windows.Controls.TextBlock lblNumero;
        
        internal System.Windows.Controls.TextBox txtNumero;
        
        internal System.Windows.Controls.StackPanel ListaDeGrupos;
        
        internal System.Windows.Controls.TextBlock lblGrupo;
        
        internal Microsoft.Phone.Controls.ListPicker lpkGrupos;
        
        internal System.Windows.Controls.StackPanel ListaDeTipos;
        
        internal System.Windows.Controls.TextBlock lblTipo;
        
        internal Microsoft.Phone.Controls.ListPicker lpkTipo;
        
        internal System.Windows.Controls.StackPanel BotaoSalvar;
        
        internal System.Windows.Controls.Button bttSalvar;
        
        internal System.Windows.Controls.StackPanel BotaoLimpar;
        
        internal System.Windows.Controls.Button bttLimpar;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/Agenda%20Telefonica;component/AddContato.xaml", System.UriKind.Relative));
            this.lpkItemTemplate = ((System.Windows.DataTemplate)(this.FindName("lpkItemTemplate")));
            this.lpkFullItemTemplate = ((System.Windows.DataTemplate)(this.FindName("lpkFullItemTemplate")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.NomePanel = ((System.Windows.Controls.StackPanel)(this.FindName("NomePanel")));
            this.lblNome = ((System.Windows.Controls.TextBlock)(this.FindName("lblNome")));
            this.txtNome = ((System.Windows.Controls.TextBox)(this.FindName("txtNome")));
            this.NumeroPanel = ((System.Windows.Controls.StackPanel)(this.FindName("NumeroPanel")));
            this.lblNumero = ((System.Windows.Controls.TextBlock)(this.FindName("lblNumero")));
            this.txtNumero = ((System.Windows.Controls.TextBox)(this.FindName("txtNumero")));
            this.ListaDeGrupos = ((System.Windows.Controls.StackPanel)(this.FindName("ListaDeGrupos")));
            this.lblGrupo = ((System.Windows.Controls.TextBlock)(this.FindName("lblGrupo")));
            this.lpkGrupos = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("lpkGrupos")));
            this.ListaDeTipos = ((System.Windows.Controls.StackPanel)(this.FindName("ListaDeTipos")));
            this.lblTipo = ((System.Windows.Controls.TextBlock)(this.FindName("lblTipo")));
            this.lpkTipo = ((Microsoft.Phone.Controls.ListPicker)(this.FindName("lpkTipo")));
            this.BotaoSalvar = ((System.Windows.Controls.StackPanel)(this.FindName("BotaoSalvar")));
            this.bttSalvar = ((System.Windows.Controls.Button)(this.FindName("bttSalvar")));
            this.BotaoLimpar = ((System.Windows.Controls.StackPanel)(this.FindName("BotaoLimpar")));
            this.bttLimpar = ((System.Windows.Controls.Button)(this.FindName("bttLimpar")));
        }
    }
}
