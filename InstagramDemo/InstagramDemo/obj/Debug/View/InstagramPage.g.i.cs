﻿#pragma checksum "C:\Users\ymoc\Desktop\Mobile Applications\InstagramDemo\InstagramDemo\View\InstagramPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D2E9DB98D52B5A6A76B94B69C9ECC091"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Coding4Fun.Toolkit.Controls;
using InstagramDemo.Data.PullToRefresh;
using Microsoft.Phone.Controls;
using SlideView.Library;
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


namespace InstagramDemo.View {
    
    
    public partial class InstagramPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal SlideView.Library.SlideView SlideView;
        
        internal System.Windows.Controls.Grid OptionList;
        
        internal System.Windows.Controls.Grid stkhome;
        
        internal System.Windows.Controls.Grid stkfb;
        
        internal System.Windows.Controls.Grid grdfb;
        
        internal System.Windows.Controls.TextBlock grdfbCount;
        
        internal System.Windows.Controls.Grid stktwt;
        
        internal System.Windows.Controls.Grid grdtwt;
        
        internal System.Windows.Controls.TextBlock grdtwtCount;
        
        internal System.Windows.Controls.Grid stklinkedin;
        
        internal System.Windows.Controls.Grid grdlinkedin;
        
        internal System.Windows.Controls.TextBlock grdlinkedinCount;
        
        internal System.Windows.Controls.Grid stkInstagram;
        
        internal System.Windows.Controls.Grid grdInstagram;
        
        internal System.Windows.Controls.TextBlock grdInstagramCount;
        
        internal System.Windows.Controls.Grid stktumblr;
        
        internal System.Windows.Controls.Grid grdtumblr;
        
        internal System.Windows.Controls.TextBlock grdtumblrCount;
        
        internal System.Windows.Controls.Grid stkvk;
        
        internal System.Windows.Controls.Grid grdvk;
        
        internal System.Windows.Controls.TextBlock grdvkCount;
        
        internal System.Windows.Controls.Grid stkmore;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal Microsoft.Phone.Controls.WebBrowser loginBrowserControl;
        
        internal System.Windows.Controls.Grid UserPanel;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Image imgOpenMenu;
        
        internal System.Windows.Controls.TextBlock header;
        
        internal System.Windows.Controls.Grid TitlePanel2;
        
        internal System.Windows.Controls.Border posts;
        
        internal System.Windows.Controls.Border follwers;
        
        internal System.Windows.Controls.Border following;
        
        internal Microsoft.Phone.Controls.Pivot ContentPivot;
        
        internal System.Windows.Controls.Grid grdposts;
        
        internal InstagramDemo.Data.PullToRefresh.PullDownToRefreshPanel refreshPanelpostInsta;
        
        internal InstagramDemo.Data.PullToRefresh.ReorderListBox postslist;
        
        internal System.Windows.Controls.Grid grdfollowers;
        
        internal InstagramDemo.Data.PullToRefresh.PullDownToRefreshPanel refreshPanelfollowersInsta;
        
        internal InstagramDemo.Data.PullToRefresh.ReorderListBox followerlistInsta;
        
        internal System.Windows.Controls.Grid grdfollowings;
        
        internal InstagramDemo.Data.PullToRefresh.PullDownToRefreshPanel refreshPanelfollowingInsta;
        
        internal InstagramDemo.Data.PullToRefresh.ReorderListBox followinglist;
        
        internal Coding4Fun.Toolkit.Controls.ProgressOverlay progressOverlay1;
        
        internal System.Windows.Controls.ProgressBar standardProgressBar;
        
        internal Coding4Fun.Toolkit.Controls.ProgressOverlay progressOverlay;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/InstagramDemo;component/View/InstagramPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.SlideView = ((SlideView.Library.SlideView)(this.FindName("SlideView")));
            this.OptionList = ((System.Windows.Controls.Grid)(this.FindName("OptionList")));
            this.stkhome = ((System.Windows.Controls.Grid)(this.FindName("stkhome")));
            this.stkfb = ((System.Windows.Controls.Grid)(this.FindName("stkfb")));
            this.grdfb = ((System.Windows.Controls.Grid)(this.FindName("grdfb")));
            this.grdfbCount = ((System.Windows.Controls.TextBlock)(this.FindName("grdfbCount")));
            this.stktwt = ((System.Windows.Controls.Grid)(this.FindName("stktwt")));
            this.grdtwt = ((System.Windows.Controls.Grid)(this.FindName("grdtwt")));
            this.grdtwtCount = ((System.Windows.Controls.TextBlock)(this.FindName("grdtwtCount")));
            this.stklinkedin = ((System.Windows.Controls.Grid)(this.FindName("stklinkedin")));
            this.grdlinkedin = ((System.Windows.Controls.Grid)(this.FindName("grdlinkedin")));
            this.grdlinkedinCount = ((System.Windows.Controls.TextBlock)(this.FindName("grdlinkedinCount")));
            this.stkInstagram = ((System.Windows.Controls.Grid)(this.FindName("stkInstagram")));
            this.grdInstagram = ((System.Windows.Controls.Grid)(this.FindName("grdInstagram")));
            this.grdInstagramCount = ((System.Windows.Controls.TextBlock)(this.FindName("grdInstagramCount")));
            this.stktumblr = ((System.Windows.Controls.Grid)(this.FindName("stktumblr")));
            this.grdtumblr = ((System.Windows.Controls.Grid)(this.FindName("grdtumblr")));
            this.grdtumblrCount = ((System.Windows.Controls.TextBlock)(this.FindName("grdtumblrCount")));
            this.stkvk = ((System.Windows.Controls.Grid)(this.FindName("stkvk")));
            this.grdvk = ((System.Windows.Controls.Grid)(this.FindName("grdvk")));
            this.grdvkCount = ((System.Windows.Controls.TextBlock)(this.FindName("grdvkCount")));
            this.stkmore = ((System.Windows.Controls.Grid)(this.FindName("stkmore")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.loginBrowserControl = ((Microsoft.Phone.Controls.WebBrowser)(this.FindName("loginBrowserControl")));
            this.UserPanel = ((System.Windows.Controls.Grid)(this.FindName("UserPanel")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.imgOpenMenu = ((System.Windows.Controls.Image)(this.FindName("imgOpenMenu")));
            this.header = ((System.Windows.Controls.TextBlock)(this.FindName("header")));
            this.TitlePanel2 = ((System.Windows.Controls.Grid)(this.FindName("TitlePanel2")));
            this.posts = ((System.Windows.Controls.Border)(this.FindName("posts")));
            this.follwers = ((System.Windows.Controls.Border)(this.FindName("follwers")));
            this.following = ((System.Windows.Controls.Border)(this.FindName("following")));
            this.ContentPivot = ((Microsoft.Phone.Controls.Pivot)(this.FindName("ContentPivot")));
            this.grdposts = ((System.Windows.Controls.Grid)(this.FindName("grdposts")));
            this.refreshPanelpostInsta = ((InstagramDemo.Data.PullToRefresh.PullDownToRefreshPanel)(this.FindName("refreshPanelpostInsta")));
            this.postslist = ((InstagramDemo.Data.PullToRefresh.ReorderListBox)(this.FindName("postslist")));
            this.grdfollowers = ((System.Windows.Controls.Grid)(this.FindName("grdfollowers")));
            this.refreshPanelfollowersInsta = ((InstagramDemo.Data.PullToRefresh.PullDownToRefreshPanel)(this.FindName("refreshPanelfollowersInsta")));
            this.followerlistInsta = ((InstagramDemo.Data.PullToRefresh.ReorderListBox)(this.FindName("followerlistInsta")));
            this.grdfollowings = ((System.Windows.Controls.Grid)(this.FindName("grdfollowings")));
            this.refreshPanelfollowingInsta = ((InstagramDemo.Data.PullToRefresh.PullDownToRefreshPanel)(this.FindName("refreshPanelfollowingInsta")));
            this.followinglist = ((InstagramDemo.Data.PullToRefresh.ReorderListBox)(this.FindName("followinglist")));
            this.progressOverlay1 = ((Coding4Fun.Toolkit.Controls.ProgressOverlay)(this.FindName("progressOverlay1")));
            this.standardProgressBar = ((System.Windows.Controls.ProgressBar)(this.FindName("standardProgressBar")));
            this.progressOverlay = ((Coding4Fun.Toolkit.Controls.ProgressOverlay)(this.FindName("progressOverlay")));
        }
    }
}

