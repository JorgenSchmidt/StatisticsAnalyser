   M S B A M L   `   `   `  ����\  XEStatAnalyser.Web.User.Desktop.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullDclr-namespace:EStatAnalyser.Web.User.Desktop.UI.ViewModels.DataViews6EStatAnalyser.Web.User.Desktop.UI.ViewModels.DataViews  5   	   L    FEStatAnalyser.Web.User.Desktop.UI.Views.DataViews.OpenSimpleDataWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   VlocalDclr-namespace:EStatAnalyser.Web.User.Desktop.UI.ViewModels.DataViews     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5	   	   $	��360��5
   	   $	��700��6    � 
ResizeMode$ NoResize=�6"   $��1q�68   
���   � � DataContext 5      T   NEStatAnalyser.Web.User.Desktop.UI.ViewModels.DataViews.OpenSimpleDataViewModel  5   
   .��5      � .+�5   
   �� $��	10,10,0,0q�6   $��30��6#   $	��200��6/   $
��Left=�6;   $	��Top=�6V   $��Запрос:��6n   �� 5   
   $��	10,40,0,0q�6)   $��20��6<   $	��120��6H   $
��Left=�6T   $	��Top=�6o   ��6   �� *Query+6o   �� 5   
   $��140, 20, 0, 0q�6,   $
��Left=�6C   $	��Top=�6^   $��
Найти��6v   $��40��6�   $��90��6�   ��6   �� *Search+6�   �� 5   
   $��240, 20, 0, 0q�6+   $
��Left=�6B   $	��Top=�6]   $��40��6u   $��90��6�   ��6   �� *Reset+.��5      ��  �� TextAlignment$ Center=�6   Сбросить к�� 6<   изначальному6V   5      �� 5   
   $��	10,80,0,0q�65   $
��Left=�6H   $	��Top=�6c   $	��245��6{   $	��320��6�   ��6   �� *	FileDatas+ �� View 5      �� 5      .P�5      �� $��ID��6%    �� Width$ 50��61    �� DisplayMemberBinding 6<   �� *Id+�� 5      $��Имя файла��6%   $	 270��68    6D   �� *
FileName+5      5      �� 5   
   $��
370,10,0,0q�6   $��25��6$   $	��100��60   $
��Left=�6<   $	��Top=�6W   $��ID файла:��6o   �� 5   
   $��
370,40,0,0q�6&   $��20��6:   $	��130��6F   $
��Left=�6R   $	��Top=�6m   ��6   �� *Id+6m   �� 5   
   $��
370,70,0,0q�6   $��25��6$   $	��130��60   $
��Left=�6<   $	��Top=�6W   $'��!Обозначение оси Х:��6o   �� 5    
   $��370,100,0,0q�6.   $��20��6C   $	��130��6O   $
��Left=�6[   $	��Top=�6v   ��6   �� *
XFieldName+6v   �� 5!   
   $��
530,70,0,0q�6   $��25��6$   $	��130��60   $
��Left=�6<   $	��Top=�6W   $&�� Обозначение оси Y:��6o   �� 5"   
   $��530,100,0,0q�6.   $��20��6C   $	��130��6O   $
��Left=�6[   $	��Top=�6v   ��6   �� *
YFieldName+6v   �� 5#   
   $��370,130,0,0q�6   $��25��6%   $	��230��61   $
��Left=�6=   $	��Top=�6X   $A��;Тип переменной (не более 3-5 слов):��6p   �� 5$   
   $��370,160,0,0q�6,   $��20��6A   $	��290��6M   $
��Left=�6Y   $	��Top=�6t   ��6   �� *
DataType+6t   �� 5%   
   $��370,190,0,0q�6   $��25��6%   $	��140��61   $
��Left=�6=   $	��Top=�6X   $&�� Описание выборки:��6p   �� 5&   
   $��370,220,0,0q�6/   $��60��6D   $	��290��6P   $
��Left=�6\   $	��Top=�6w    �� TextWrapping$
 Wrap=�6�   ��6   �� *Description+6�   �� 5'   
   $��370, 300, 0, 0q�6*   $��Отправить��6B   $
��Left=�6V   $	��Top=�6q   $��25��6�   $��90��6�   ��6   �� *Send+6�   �� 5(   
   $��470, 300, 0, 0q�6*   $��Справка��6B   $
��Left=�6T   $	��Top=�6o   $��25��6�   $��90��6�   ��6   �� *Help+6�   �� 5)   
   $��570, 300, 0, 0q�6+   $��Закрыть��6C   $
��Left=�6U   $	��Top=�6p   $��25��6�   $��90��6�   ��6   �� *Close+6�   5*      5+      