   M S B A M L   `   `   `  ����\  XEStatAnalyser.Web.User.Desktop.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullDclr-namespace:EStatAnalyser.Web.User.Desktop.UI.ViewModels.DataViews6EStatAnalyser.Web.User.Desktop.UI.ViewModels.DataViews  5   	   K    EEStatAnalyser.Web.User.Desktop.UI.Views.DataViews.OpenUploadingWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   VlocalDclr-namespace:EStatAnalyser.Web.User.Desktop.UI.ViewModels.DataViews     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5	   	   $	��290��5
   	   $	��540��6    � 
ResizeMode$ NoResize=�6"   $��1q�68   
���   � � DataContext 5      S   MEStatAnalyser.Web.User.Desktop.UI.ViewModels.DataViews.OpenUploadingViewModel  5   
   .��5      � .+�5   
   �� $��	10,10,0,0q�6   $��30��6#   $	��200��6/   $
��Left=�6;   $	��Top=�6V   $��Запрос:��6n   �� 5   
   $��	10,40,0,0q�6)   $��20��6<   $	��120��6H   $
��Left=�6T   $	��Top=�6o   ��6   �� *Query+6o   �� 5   
   $��140, 20, 0, 0q�6,   $
��Left=�6C   $	��Top=�6^   $��
Найти��6v   $��40��6�   $��90��6�   ��6   �� *Search+6�   �� 5   
   $��240, 20, 0, 0q�6+   $
��Left=�6B   $	��Top=�6]   $��40��6u   $��90��6�   ��6   �� *Reset+.��5      ��  �� TextAlignment$ Center=�6   Сбросить к�� 6<   изначальному6W   5      �� 5   
   $��	10,80,0,0q�65   $
��Left=�6H   $	��Top=�6c   $	��180��6{   $	��320��6�   ��6   �� *	FileDatas+ �� View 5      �� 5      .P�5      �� $��ID��6%    �� Width$ 50��61    �� DisplayMemberBinding 6<   �� *Id+�� 5      $��Имя файла��6%   $	 270��68    6D   �� *
FileName+5      5      �� 5   
   $��
370,10,0,0q�6   $��25��6$   $	��200��60   $
��Left=�6<   $	��Top=�6W   $��ID файла:��6o   �� 5   
   $��
370,40,0,0q�6&   $��20��6:   $	��130��6F   $
��Left=�6R   $	��Top=�6m   ��6   �� *Id+6m   �� 5    
   $��370, 70, 0, 0q�6.   $*��$Открыть для анализа��6E   $
��Left=�6c   $	��Top=�6~   $��25��6�   $	��130��6�   ��6   �� *
Analysis+6�   �� 5!   
   $��370, 105, 0, 0q�6.   $ ��Отправить по ID��6F   $
��Left=�6`   $	��Top=�6{   $��25��6�   $	��130��6�   ��6   �� *
SendByID+6�   �� 5"   
   $��370, 140, 0, 0q�6-   $��Отправить все��6E   $
��Left=�6]   $	��Top=�6x   $��25��6�   $	��130��6�   ��6   �� *	SendAll+6�   �� 5$   
   $��370, 200, 0, 0q�6*   $��Справка��6B   $
��Left=�6T   $	��Top=�6o   $��25��6�   $	��130��6�   ��6   �� *Help+6�   �� 5%   
   $��370, 235, 0, 0q�6+   $��Закрыть��6C   $
��Left=�6U   $	��Top=�6p   $��25��6�   $	��130��6�   ��6   �� *Close+6�   5&      5'      