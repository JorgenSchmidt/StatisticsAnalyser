   M S B A M L   `   `   `  ����\  XEStatAnalyser.Web.User.Desktop.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullk:clr-namespace:EStatAnalyser.Web.User.Desktop.UI.ViewModels,EStatAnalyser.Web.User.Desktop.UI.ViewModels  5   	   9    3EStatAnalyser.Web.User.Desktop.UI.Views.EntryWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Llocal:clr-namespace:EStatAnalyser.Web.User.Desktop.UI.ViewModels     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � 
ResizeMode$ NoResize=�5	   	    � Title$# Statistics Analyser v.0.0.0.1��5
   	   $	��225��6/   $	��300��6<    � DataContext 5      G   AEStatAnalyser.Web.User.Desktop.UI.ViewModels.EntryWindowViewModel  5   
   .��5      � ���#efefef.+�5   
   �� $��30, 10, 0, 0q�64   $
��Left=�6J   $	��Top=�6e   $4��.Открыть загрузочный файл��6}   $��30��6�   $	��225��6�   ��6   �� *OpenUploadFile+6�   �� 5   
   $��30, 50, 0, 0q�64   $
��Left=�6J   $	��Top=�6e   $"��Открыть .dat файл��6}   $��30��6�   $	��225��6�   ��6   �� *OpenSimpleFile+6�   �� 5   
   $��30, 90, 0, 0q�62   $
��Left=�6H   $	��Top=�6c   $-��'Получить данные из БД��6{   $��30��6�   $	��225��6�   ��6   �� *OpenDataBase+6�   �� 5   
   $��30, 140, 0, 0q�6-   $
��Left=�6D   $	��Top=�6_   $��Справка��6w   $��30��6�   $	��225��6�   ��6   �� *	GetInfo+6�   5      5      