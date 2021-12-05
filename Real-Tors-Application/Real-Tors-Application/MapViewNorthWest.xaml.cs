﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Real_Tors_Application
{
    /// <summary>
    /// Interaction logic for MapViewNorthWest.xaml
    /// </summary>
    public partial class MapViewNorthWest : Page
    {

        public MapViewNorthWest()
        {
            InitializeComponent();
            SetAllNWParam();
            SetMapValues();

            FillList();
            profileButtonVisibility();
        }

        private void Btn_Zoomout_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("MapViewUnZoomed.xaml", UriKind.Relative));
        }

        private void Btn_ListView_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ListView.xaml", UriKind.Relative));
        }

/*        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("HomePage.xaml", UriKind.Relative));
        }*/

        private void navLogInButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("LoginView.xaml", UriKind.Relative));
        }

        private void signUpButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("SignupView.xaml", UriKind.Relative));
        }

/*        private void toggleTypes(object sender, RoutedEventArgs e)
        {
            if (HomeTypesSelect.Visibility == Visibility.Collapsed)
            {
                HomeTypesSelect.Visibility = Visibility.Visible;
            }
            else
            {
                HomeTypesSelect.Visibility = Visibility.Collapsed;
            }
        }*/

/*        private void OpenAmenities_Click(object sender, RoutedEventArgs e)
        {
            if (AmenTypesSelect.Visibility == Visibility.Collapsed)
            {
                AmenTypesSelect.Visibility = Visibility.Visible;
            }
            else
            {
                AmenTypesSelect.Visibility = Visibility.Collapsed;
            }

        }

        private void toggleNeigh(object sender, RoutedEventArgs e)
        {
            if (NeighTypesSelect.Visibility == Visibility.Collapsed)
            {
                NeighTypesSelect.Visibility = Visibility.Visible;
            }
            else
            {
                NeighTypesSelect.Visibility = Visibility.Collapsed;
            }
        }*/

/*        private void ToggleFilter(object sender, RoutedEventArgs e)
        {
            if (FilterPanel.Visibility == Visibility.Collapsed)
            {
                FilterPanel.Visibility = Visibility.Visible;

            }
            else
            {
                FilterPanel.Visibility = Visibility.Collapsed;

            }

        }*/

        private void SetAllNWParam()
        {
            GlobalState.paramNeighbourhood.Clear();
            GlobalState.paramNeighbourhood.Add("Citadel");
            GlobalState.paramNeighbourhood.Add("Edgemont");
            GlobalState.paramNeighbourhood.Add("Hamptons");
            GlobalState.paramNeighbourhood.Add("Hawkwood");
            GlobalState.paramNeighbourhood.Add("Simons Valley");

            GlobalState.paramNeighbourhood.Add("Arbour Lake");
            GlobalState.paramNeighbourhood.Add("Dalhousie");
            GlobalState.paramNeighbourhood.Add("Nolan Hill");
            GlobalState.paramNeighbourhood.Add("Ranchlands");
            GlobalState.paramNeighbourhood.Add("Rockey Ridge");
            GlobalState.paramNeighbourhood.Add("Royal Oak");
            GlobalState.paramNeighbourhood.Add("Royal Vista");
            GlobalState.paramNeighbourhood.Add("Sage Hill");
            GlobalState.paramNeighbourhood.Add("Scenic Acres");
            GlobalState.paramNeighbourhood.Add("Silver Springs");
            GlobalState.paramNeighbourhood.Add("Tuscany");
        }

        private void SetMapValues()
        {

            GlobalState.setPerNeighbourhood("Citadel");
            GlobalState.setPerNeighbourhood("Edgemont");
            GlobalState.setPerNeighbourhood("Hamptons");
            GlobalState.setPerNeighbourhood("Hawkwood");
            GlobalState.setPerNeighbourhood("Simons Valley");

            GlobalState.setPerNeighbourhood("Arbour Lake");
            GlobalState.setPerNeighbourhood("Dalhousie");
            GlobalState.setPerNeighbourhood("Nolan Hill");
            GlobalState.setPerNeighbourhood("Ranchlands");
            GlobalState.setPerNeighbourhood("Rockey Ridge");
            GlobalState.setPerNeighbourhood("Royal Oak");
            GlobalState.setPerNeighbourhood("Royal Vista");
            GlobalState.setPerNeighbourhood("Sage Hill");
            GlobalState.setPerNeighbourhood("Scenic Acres");
            GlobalState.setPerNeighbourhood("Silver Springs");
            GlobalState.setPerNeighbourhood("Tuscany");

            LBL_Citadel.Content = GlobalState.perNeighbourhood["Citadel"];
            LBL_Edgemont.Content = GlobalState.perNeighbourhood["Edgemont"];
            LBL_Hamptons.Content = GlobalState.perNeighbourhood["Hamptons"];
            LBL_Hawkwood.Content = GlobalState.perNeighbourhood["Hawkwood"];
            LBL_SimonsValley.Content = GlobalState.perNeighbourhood["Simons Valley"];

            LBL_ArbourLake.Content = GlobalState.perNeighbourhood["Arbour Lake"];
            LBL_Dalhousie.Content = GlobalState.perNeighbourhood["Dalhousie"];
            LBL_NolanHill.Content = GlobalState.perNeighbourhood["Nolan Hill"];
            LBL_Ranchlands.Content = GlobalState.perNeighbourhood["Ranchlands"];
            LBL_RockeyRidge.Content = GlobalState.perNeighbourhood["Rockey Ridge"];
            LBL_RoyalOak.Content = GlobalState.perNeighbourhood["Royal Oak"];
            LBL_RoyalVista.Content = GlobalState.perNeighbourhood["Royal Vista"];
            LBL_SageHill.Content = GlobalState.perNeighbourhood["Sage Hill"];
            LBL_ScenicAcres.Content = GlobalState.perNeighbourhood["Scenic Acres"];
            LBL_SilverSprings.Content = GlobalState.perNeighbourhood["Silver Springs"];
            LBL_Tuscany.Content = GlobalState.perNeighbourhood["Tuscany"];

            SetLabelColor(LBL_Citadel);
            SetLabelColor(LBL_Edgemont);
            SetLabelColor(LBL_Hamptons);
            SetLabelColor(LBL_Hawkwood);
            SetLabelColor(LBL_SimonsValley);

            SetLabelColor(LBL_ArbourLake);
            SetLabelColor(LBL_Dalhousie);
            SetLabelColor(LBL_NolanHill);
            SetLabelColor(LBL_Ranchlands);
            SetLabelColor(LBL_RockeyRidge);
            SetLabelColor(LBL_RoyalOak);
            SetLabelColor(LBL_RoyalVista);
            SetLabelColor(LBL_SageHill);
            SetLabelColor(LBL_ScenicAcres);
            SetLabelColor(LBL_SilverSprings);
            SetLabelColor(LBL_Tuscany);
        }

        private void SetLabelColor(Label label)
        {
            if((int) label.Content <= 50)
            {
                label.Foreground = Brushes.DeepSkyBlue;
            }
            else if ((int)label.Content <= 60)
            {
                label.Foreground = Brushes.DodgerBlue;
            }
            else if ((int)label.Content <= 70)
            {
                label.Foreground = Brushes.Blue;
            }
            else
            {
                label.Foreground = Brushes.Navy;
            }
        }

        private void Btn_Citadel(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/MapView-FullyZoomed/MapViewCitadel.xaml", UriKind.Relative));
        }

        private void MouseOverCitadel(object sender, MouseEventArgs e)
        {
            Citadel.Opacity = 1;
        }

        private void MouseOutCitadel(object sender, MouseEventArgs e)
        {
            Citadel.Opacity = 0;
        }

        private void Btn_Edgemont(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/MapView-FullyZoomed/MapViewEdgemont.xaml", UriKind.Relative));
        }

        private void MouseOverEdgemont(object sender, MouseEventArgs e)
        {
            Edgemont.Opacity = 1;
        }

        private void MouseOutEdgemont(object sender, MouseEventArgs e)
        {
            Edgemont.Opacity = 0;
        }

        private void Btn_Hamptons(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/MapView-FullyZoomed/MapViewHamptons.xaml", UriKind.Relative));
        }

        private void MouseOverHamptons(object sender, MouseEventArgs e)
        {
            Hamptons.Opacity = 1;
        }

        private void MouseOutHamptons(object sender, MouseEventArgs e)
        {
            Hamptons.Opacity = 0;
        }

        private void Btn_SimonsValley(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/MapView-FullyZoomed/MapViewSimonsValley.xaml", UriKind.Relative));
        }

        private void MouseOverSimonsValley(object sender, MouseEventArgs e)
        {
            SimonsValley.Opacity = 1;
        }

        private void MouseOutSimonsValley(object sender, MouseEventArgs e)
        {
            SimonsValley.Opacity = 0;
        }

        private void Btn_Hawkwood(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("/MapView-FullyZoomed/MapViewHawkwood.xaml", UriKind.Relative));
        }

        private void MouseOverHawkwood(object sender, MouseEventArgs e)
        {
            Hawkwood.Opacity = 1;
        }

        private void MouseOutHawkwood(object sender, MouseEventArgs e)
        {
            Hawkwood.Opacity = 0;
        }

        private void MouseOverArbourLake(object sender, MouseEventArgs e)
        {
            ArbourLake.Opacity = 1;
        }

        private void MouseOutArbourLake(object sender, MouseEventArgs e)
        {
            ArbourLake.Opacity = 0;
        }

        private void MouseOverDalhousie(object sender, MouseEventArgs e)
        {
            Dalhousie.Opacity = 1;
        }

        private void MouseOutDalhousie(object sender, MouseEventArgs e)
        {
            Dalhousie.Opacity = 0;
        }

        private void MouseOverNolanHill(object sender, MouseEventArgs e)
        {
            NolanHill.Opacity = 1;
        }

        private void MouseOutNolanHill(object sender, MouseEventArgs e)
        {
            NolanHill.Opacity = 0;
        }

        private void MouseOverRanchlands(object sender, MouseEventArgs e)
        {
            Ranchlands.Opacity = 1;
        }

        private void MouseOutRanchlands(object sender, MouseEventArgs e)
        {
            Ranchlands.Opacity = 0;
        }

        private void MouseOverRockeyRidge(object sender, MouseEventArgs e)
        {
            RockeyRidge.Opacity = 1;
        }

        private void MouseOutRockeyRidge(object sender, MouseEventArgs e)
        {
            RockeyRidge.Opacity = 0;
        }

        private void MouseOverRoyalOak(object sender, MouseEventArgs e)
        {
            RoyalOak.Opacity = 1;
        }

        private void MouseOutRoyalOak(object sender, MouseEventArgs e)
        {
            RoyalOak.Opacity = 0;
        }

        private void MouseOverRoyalVista(object sender, MouseEventArgs e)
        {
            RoyalVista.Opacity = 1;
        }

        private void MouseOutRoyalVista(object sender, MouseEventArgs e)
        {
            RoyalVista.Opacity = 0;
        }

        private void MouseOverSageHill(object sender, MouseEventArgs e)
        {
            SageHill.Opacity = 1;
        }

        private void MouseOutSageHill(object sender, MouseEventArgs e)
        {
            SageHill.Opacity = 0;
        }

        private void MouseOverScenicAcres(object sender, MouseEventArgs e)
        {
            ScenicAcres.Opacity = 1;
        }

        private void MouseOutScenicAcres(object sender, MouseEventArgs e)
        {
            ScenicAcres.Opacity = 0;
        }

        private void MouseOverSilverSprings(object sender, MouseEventArgs e)
        {
            SilverSprings.Opacity = 1;
        }

        private void MouseOutSilverSprings(object sender, MouseEventArgs e)
        {
            SilverSprings.Opacity = 0;
        }

        private void MouseOverTuscany(object sender, MouseEventArgs e)
        {
            Tuscany.Opacity = 1;
        }

        private void MouseOutTuscany(object sender, MouseEventArgs e)
        {
            Tuscany.Opacity = 0;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///Filters and Header Stuff

        public bool isOnAccount;
        private void profileButtonVisibility()
        {
            if (GlobalState.isLoggedIn)
            {
                profileButton.Visibility = Visibility.Visible;
            }
            else
            {
                profileButton.Visibility = Visibility.Collapsed;
            }
        }

        private void aboutButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("AboutView.xaml", UriKind.Relative));
        }

        private void teamButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("OurTeamView.xaml", UriKind.Relative));
        }

        private void homeButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("LoginView.xaml", UriKind.Relative));
        }
/*
        private void navLogInButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("LoginView.xaml", UriKind.Relative));
        }

        private void signUpButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("SignupView.xaml", UriKind.Relative));
        }
*/
        private void contactButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ContactUsView.xaml", UriKind.Relative));
        }

        private void profileButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("ProfileView.xaml", UriKind.Relative));
        }




        private void toggleTypes(object sender, RoutedEventArgs e)
        {
            if (!GlobalState.isTypeExpanded)
            {
                dropdown_btn_image.Source = new BitmapImage(new Uri("sortup_icon.png", UriKind.RelativeOrAbsolute));
                HomeTypesSelect.Visibility = Visibility.Visible;

            }
            else
            {
                dropdown_btn_image.Source = new BitmapImage(new Uri("sortdown_icon.png", UriKind.RelativeOrAbsolute));
                HomeTypesSelect.Visibility = Visibility.Collapsed;
            }
            GlobalState.isTypeExpanded = !GlobalState.isTypeExpanded;
        }


        private void ToggleFilter(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine("Toggle Pressed");
            //timer.Start();
            if (FilterPanel.Visibility == Visibility.Collapsed)
            {

                FilterPanel.Visibility = Visibility.Visible;
                
                GlobalState.isOpen = true;

            }
            else
            {

                FilterPanel.Visibility = Visibility.Collapsed;
                
                GlobalState.isOpen = false;
            }
        }

        private void FillList()
        {
            if (GlobalState.isOpen)
            {
                FilterPanel.Visibility = Visibility.Visible;
                
            }
            else
            {
                FilterPanel.Visibility = Visibility.Collapsed;
                
            }

            if (GlobalState.isLoggedIn)
            {
                profileButton.Visibility = Visibility.Visible;
            }

            if (!GlobalState.isTypeExpanded)
            {
                dropdown_btn_image.Source = new BitmapImage(new Uri("sortdown_icon.png", UriKind.RelativeOrAbsolute));
                HomeTypesSelect.Visibility = Visibility.Collapsed;
            }
            else
            {
                dropdown_btn_image.Source = new BitmapImage(new Uri("sortup_icon.png", UriKind.RelativeOrAbsolute));
                HomeTypesSelect.Visibility = Visibility.Visible;
            }

            switch (GlobalState.paramType)
            {
                case ListingType.SingleFamily:
                    SingleButt.IsChecked = true;
                    break;
                case ListingType.Duplex:
                    DuplexButt.IsChecked = true;
                    break;
                case ListingType.Triplex:
                    TriplexButt.IsChecked = true;
                    break;
                case ListingType.Apartment:
                    ApartButt.IsChecked = true;
                    break;
                case ListingType.Townhome:
                    TownhomeButt.IsChecked = true;
                    break;
                case ListingType.Loft:
                    LoftButt.IsChecked = true;
                    break;
            }


            if (GlobalState.paramPrice != null)
            {
                if (GlobalState.paramPrice.Item1 != 0)
                {
                    lowPrice.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    lowPrice.Text = GlobalState.paramPrice.Item1.ToString();
                }
                if (GlobalState.paramPrice.Item2 != 25000000)
                {
                    highPrice.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    highPrice.Text = GlobalState.paramPrice.Item2.ToString();
                }
            }

            if (GlobalState.paramSize != null)
            {
                if (GlobalState.paramSize.Item1 != 0)
                {
                    lowSize.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    lowSize.Text = GlobalState.paramSize.Item1.ToString();
                }
                if (GlobalState.paramPrice.Item2 != 20000)
                {
                    highSize.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    highSize.Text = GlobalState.paramSize.Item2.ToString();
                }
            }

            if (GlobalState.paramBed != null)
            {
                if (GlobalState.paramBed.Item1 != 0)
                {
                    lowBed.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    lowBed.Text = GlobalState.paramBed.Item1.ToString();
                }
                if (GlobalState.paramBed.Item2 != 6)
                {
                    highBed.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    highBed.Text = GlobalState.paramBed.Item2.ToString();
                }
            }

            if (GlobalState.paramBath != null)
            {
                if (GlobalState.paramBath.Item1 != 0)
                {
                    lowBath.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    lowBath.Text = GlobalState.paramBath.Item1.ToString();
                }
                if (GlobalState.paramBath.Item2 != 6)
                {
                    highBath.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    highBath.Text = GlobalState.paramBath.Item2.ToString();
                }
            }

            if (GlobalState.paramYear != null)
            {
                if (GlobalState.paramYear.Item1 != 0)
                {
                    lowYear.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    lowYear.Text = GlobalState.paramYear.Item1.ToString();
                }
                if (GlobalState.paramPrice.Item2 != 2021)
                {
                    highYear.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    highYear.Text = GlobalState.paramYear.Item2.ToString();
                }
            }

            Print_Amenity();
            Print_Neighbourhood();
        }


        private void Add_Amenity_Click(object sender, RoutedEventArgs e)
        {
            AddAmenity();
        }

        private void EnterAmenity(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Return)
            {
                AddAmenity();
            }
        }

        private void AddAmenity()
        {
            if (AmenitiesInput.Text != null && !GlobalState.paramAmenities.Contains(AmenitiesInput.Text) && GlobalState.paramAmenities.Count() < 5 && AmenitiesInput.Text.Count() > 0)
            {
                GlobalState.paramAmenities.Add(AmenitiesInput.Text);
                AmenitiesInput.Text = "";
                Print_Amenity();
                GlobalState.Generate(9);
                
            }
        }

        private void DeleteAmenity(object sender, MouseButtonEventArgs e)
        {
            var lbl = sender as Label;

            GlobalState.paramAmenities.Remove(lbl.Content.ToString().Substring(2));
            Print_Amenity();
            GlobalState.Generate(9);
            
        }

        private void Print_Amenity()
        {
            Amenity1.Visibility = Visibility.Collapsed;
            Amenity2.Visibility = Visibility.Collapsed;
            Amenity3.Visibility = Visibility.Collapsed;
            Amenity4.Visibility = Visibility.Collapsed;
            Amenity5.Visibility = Visibility.Collapsed;
            int count = GlobalState.paramAmenities.Count;
            AddAmenities.IsEnabled = true;
            if (count >= 1)
            {
                Amenity1.Content = "x " + GlobalState.paramAmenities[0];
                Amenity1.Visibility = Visibility.Visible;

                if (count >= 2)
                {
                    Amenity2.Content = "x " + GlobalState.paramAmenities[1];
                    Amenity2.Visibility = Visibility.Visible;

                    if (count >= 3)
                    {
                        Amenity3.Content = "x " + GlobalState.paramAmenities[2];
                        Amenity3.Visibility = Visibility.Visible;

                        if (count >= 4)
                        {
                            Amenity4.Content = "x " + GlobalState.paramAmenities[3];
                            Amenity4.Visibility = Visibility.Visible;

                            if (count >= 5)
                            {
                                Amenity5.Content = "x " + GlobalState.paramAmenities[4];
                                Amenity5.Visibility = Visibility.Visible;
                                AddAmenities.IsEnabled = false;

                            }
                        }
                    }
                }
            }
        }



        private void Add_Neighbourhood_Click(object sender, RoutedEventArgs e)
        {
            AddNeighbour();
        }

        private void EnterNeighbour(object sender, KeyEventArgs e)
        {

            if (e.Key == Key.Return)
            {
                AddNeighbour();
            }
        }

        private void AddNeighbour()
        {
            if (NeighbourhoodInput.Text != null && !GlobalState.paramNeighbourhood.Contains(NeighbourhoodInput.Text) && GlobalState.paramNeighbourhood.Count() < 6 && NeighbourhoodInput.Text.Count() > 0)
            {
                GlobalState.paramNeighbourhood.Add(NeighbourhoodInput.Text);
                NeighbourhoodInput.Text = "";
                Print_Neighbourhood();
                GlobalState.Generate(9);
                
            }
        }

        private void DeleteNeighbour(object sender, MouseButtonEventArgs e)
        {
            var lbl = sender as Label;
            GlobalState.paramNeighbourhood.Remove(lbl.Content.ToString().Substring(2));
            Print_Neighbourhood();
            GlobalState.Generate(9);
            
        }

        private void Print_Neighbourhood()
        {
            Neighbour1.Visibility = Visibility.Collapsed;
            Neighbour2.Visibility = Visibility.Collapsed;
            Neighbour3.Visibility = Visibility.Collapsed;
            Neighbour4.Visibility = Visibility.Collapsed;
            Neighbour5.Visibility = Visibility.Collapsed;
            int count = GlobalState.paramNeighbourhood.Count;
            AddNeighbourhood.IsEnabled = true;
            if (count >= 1)
            {
                Neighbour1.Content = "x " + GlobalState.paramNeighbourhood[0];
                Neighbour1.Visibility = Visibility.Visible;

                if (count >= 2)
                {
                    Neighbour2.Content = "x " + GlobalState.paramNeighbourhood[1];
                    Neighbour2.Visibility = Visibility.Visible;

                    if (count >= 3)
                    {
                        Neighbour3.Content = "x " + GlobalState.paramNeighbourhood[2];
                        Neighbour3.Visibility = Visibility.Visible;

                        if (count >= 4)
                        {
                            Neighbour4.Content = "x " + GlobalState.paramNeighbourhood[3];
                            Neighbour4.Visibility = Visibility.Visible;

                            if (count >= 5)
                            {
                                Neighbour5.Content = "x " + GlobalState.paramNeighbourhood[4];
                                Neighbour5.Visibility = Visibility.Visible;

                                if (count >= 6)
                                {
                                    Neighbour6.Content = "x " + GlobalState.paramNeighbourhood[5];
                                    Neighbour6.Visibility = Visibility.Visible;
                                    AddNeighbourhood.IsEnabled = false;
                                }

                            }
                        }
                    }
                }
            }
        }


        private void enterPriceLow(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                lowPrice.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
                return;
            }
            if (e.Key == Key.Return)
            {

                if (int.TryParse(lowPrice.Text, out _))
                {
                    int high = 25000000;
                    if (GlobalState.paramPrice != null)
                    {
                        high = GlobalState.paramPrice.Item2;
                    }
                    GlobalState.paramPrice = new Tuple<int, int>(int.Parse(lowPrice.Text), high);
                    lowPrice.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    GlobalState.Generate(9);
                    
                }
            }
            else
            {
                lowPrice.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
            }
        }

        private void enterPriceHigh(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                highPrice.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
                return;
            }

            if (e.Key == Key.Return)
            {

                if (int.TryParse(highPrice.Text, out _))
                {
                    int low = 0;
                    if (GlobalState.paramPrice != null)
                    {
                        low = GlobalState.paramPrice.Item1;
                    }
                    GlobalState.paramPrice = new Tuple<int, int>(low, int.Parse(highPrice.Text));
                    highPrice.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    GlobalState.Generate(9);
                    
                }
            }
            else
            {
                highPrice.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
            }
        }

        private void enterSizeLow(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                lowSize.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
                return;
            }
            if (e.Key == Key.Return)
            {

                if (int.TryParse(lowSize.Text, out _))
                {
                    int high = 20000;
                    if (GlobalState.paramSize != null)
                    {
                        high = GlobalState.paramSize.Item2;
                    }
                    GlobalState.paramSize = new Tuple<int, int>(int.Parse(lowSize.Text), high);
                    lowSize.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    GlobalState.Generate(9);
                    
                }
            }
            else
            {
                lowSize.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
            }
        }

        private void enterSizeHigh(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                highSize.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
                return;
            }

            if (e.Key == Key.Return)
            {

                if (int.TryParse(highSize.Text, out _))
                {
                    int low = 0;
                    if (GlobalState.paramSize != null)
                    {
                        low = GlobalState.paramSize.Item1;
                    }
                    GlobalState.paramSize = new Tuple<int, int>(low, int.Parse(highSize.Text));
                    highSize.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    GlobalState.Generate(9);
                    
                }
            }
            else
            {
                highSize.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
            }
        }


        private void enterBedLow(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                lowBed.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
                return;
            }
            if (e.Key == Key.Return)
            {

                if (int.TryParse(lowBed.Text, out _))
                {
                    int high = 6;
                    if (GlobalState.paramBed != null)
                    {
                        high = GlobalState.paramBed.Item2;
                    }
                    GlobalState.paramBed = new Tuple<int, int>(int.Parse(lowBed.Text), high);
                    lowBed.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    GlobalState.Generate(9);
                    
                }
            }
            else
            {
                lowBed.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
            }
        }

        private void enterBedHigh(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                highBed.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
                return;
            }

            if (e.Key == Key.Return)
            {

                if (int.TryParse(highBed.Text, out _))
                {
                    int low = 0;
                    if (GlobalState.paramBed != null)
                    {
                        low = GlobalState.paramBed.Item1;
                    }
                    GlobalState.paramBed = new Tuple<int, int>(low, int.Parse(highBed.Text));
                    highBed.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    GlobalState.Generate(9);
                    
                }
            }
            else
            {
                highBed.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
            }
        }


        private void enterBathLow(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                lowBath.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
                return;
            }
            if (e.Key == Key.Return)
            {

                if (int.TryParse(lowBath.Text, out _))
                {
                    int high = 6;
                    if (GlobalState.paramBath != null)
                    {
                        high = GlobalState.paramBath.Item2;
                    }
                    GlobalState.paramBath = new Tuple<int, int>(int.Parse(lowBath.Text), high);
                    lowBath.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    GlobalState.Generate(9);
                    
                }
            }
            else
            {
                lowBath.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
            }
        }

        private void enterBathHigh(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                highBath.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
                return;
            }

            if (e.Key == Key.Return)
            {

                if (int.TryParse(highBath.Text, out _))
                {
                    int low = 0;
                    if (GlobalState.paramBath != null)
                    {
                        low = GlobalState.paramBath.Item1;
                    }
                    GlobalState.paramBath = new Tuple<int, int>(low, int.Parse(highBath.Text));
                    highBath.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    GlobalState.Generate(9);
                    
                }
            }
            else
            {
                highBath.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
            }
        }


        private void enterYearLow(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                lowYear.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
                return;
            }
            if (e.Key == Key.Return)
            {

                if (int.TryParse(lowYear.Text, out _))
                {
                    int high = 2021;
                    if (GlobalState.paramYear != null)
                    {
                        high = GlobalState.paramYear.Item2;
                    }
                    GlobalState.paramYear = new Tuple<int, int>(int.Parse(lowYear.Text), high);
                    lowYear.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    GlobalState.Generate(9);
                   
                }
            }
            else
            {
                lowYear.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
            }
        }

        private void enterYearHigh(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back)
            {
                highYear.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
                return;
            }

            if (e.Key == Key.Return)
            {

                if (int.TryParse(highYear.Text, out _))
                {
                    int low = 0;
                    if (GlobalState.paramYear != null)
                    {
                        low = GlobalState.paramYear.Item1;
                    }
                    GlobalState.paramYear = new Tuple<int, int>(low, int.Parse(highYear.Text));
                    highYear.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF9DEA8C"));
                    GlobalState.Generate(9);
                    
                }
            }
            else
            {
                highYear.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#eee"));
            }
        }

        private void SingleFamily_Click(object sender, RoutedEventArgs e)
        {
            GlobalState.paramType = ListingType.SingleFamily;
        }

        private void Duplex_Click(object sender, RoutedEventArgs e)
        {
            GlobalState.paramType = ListingType.Duplex;
        }

        private void Triplex_Click(object sender, RoutedEventArgs e)
        {
            GlobalState.paramType = ListingType.Triplex;
        }

        private void Townhome_Click(object sender, RoutedEventArgs e)
        {
            GlobalState.paramType = ListingType.Townhome;
        }

        private void Apartment_Click(object sender, RoutedEventArgs e)
        {
            GlobalState.paramType = ListingType.Apartment;
        }

        private void Loft_Click(object sender, RoutedEventArgs e)
        {
            GlobalState.paramType = ListingType.Loft;
        }

        private void MouseOnLogin(object sender, MouseEventArgs e)
        {
            isOnAccount = true;
        }
        private void MouseOutLogin(object sender, MouseEventArgs e)
        {
            isOnAccount = false;
        }

        private void createAccountButtonAC_Click(object sender, RoutedEventArgs e)
        {
            if (inputValidation())
            {
                signupGrid.Visibility = Visibility.Hidden;
                successSignupGrid.Visibility = Visibility.Visible;
            }
        }

        private bool inputValidation()
        {
            var bc = new BrushConverter();
            bool valid = true;
            // Error Background = "#FFFFB7B7"
            String username = userNameTextBoxAC.Text;
            String password = passwordTextBoxAC.Password;
            String email = emailTextBoxAC.Text;
            // Check username 
            if (username.Equals(""))
            {
                userNameTextBoxAC.Background = (Brush)bc.ConvertFrom("#FFFFB7B7");
                valid = false;
            }
            else
            {
                userNameTextBoxAC.Background = (Brush)bc.ConvertFrom("#FFFFFFFF");
            }
            // Check password
            if (password.Equals(""))
            {
                passwordTextBoxAC.Background = (Brush)bc.ConvertFrom("#FFFFB7B7");
                valid = false;
            }
            else
            {
                passwordTextBoxAC.Background = (Brush)bc.ConvertFrom("#FFFFFFFF");
            }
            // Check email
            if (email.Equals(""))
            {
                emailTextBoxAC.Background = (Brush)bc.ConvertFrom("#FFFFB7B7");
                valid = false;
            }
            else
            {
                emailTextBoxAC.Background = (Brush)bc.ConvertFrom("#FFFFFFFF");
            }

            return valid;
        }

        private void logInButton_Click(object sender, RoutedEventArgs e)
        {
            GlobalState.isLoggedIn = true;
            AccountPopUp.Visibility = Visibility.Hidden;
            profileButtonVisibility();
        }

        private void loginButtonSUCC_Click(object sender, RoutedEventArgs e)
        {
            successSignupGrid.Visibility = Visibility.Hidden;
            logInGrid.Visibility = Visibility.Visible;
        }

        private void createAcccountTextButton_Click(object sender, RoutedEventArgs e)
        {
            logInGrid.Visibility = Visibility.Hidden;
            signupGrid.Visibility = Visibility.Visible;
        }

        private void RemoveAccountPopUp(object sender, MouseButtonEventArgs e)
        {
            if (!isOnAccount)
            {
                AccountPopUp.Visibility = Visibility.Collapsed;
            }

        }

        //Make it so, if a favorite is attempted to be changed, and the user is not logged in, then fun this
        private void AccountPopsUp()
        {
            AccountPopUp.Visibility = Visibility.Visible;
            logInGrid.Visibility = Visibility.Visible;
            signupGrid.Visibility = Visibility.Collapsed;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
