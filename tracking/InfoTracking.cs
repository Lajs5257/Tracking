using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tracking
{
    public partial class InfoTracking : Form
    {
        #region VARIABLES PRIVADAS


        #endregion
        #region PROPIEDADES
        public string Supply_chain_id
        {
            get { return lb_supply_chain_id.Text; }
            set { lb_supply_chain_id.Text = value; }
        }
        public string Id
        {
            get { return lb_id.Text; }
            set { lb_id.Text = value; }
        }
        public string Plante
        {
            get { return lb_plante.Text; }
            set { lb_plante.Text = value; }
        }
        public string Shipment{
            get { return lb_shipment.Text; }
            set { lb_shipment.Text = value; }
        }
        public string Transline_name
        {
            get { return lb_transline_name.Text; }
            set { lb_transline_name.Text = value; }
        }
        public string Transline_id
        {
            get { return lb_transline_id.Text; }
            set { lb_transline_id.Text = value; }
        }
        public string Legacy_code
        {
            get { return lb_legacy_code.Text; }
            set { lb_legacy_code.Text = value; }
        }
        public string Timezone
        {
            get { return lb_timezone.Text; }
            set { lb_timezone.Text = value; }
        }
        public string Latitude
        {
            get { return lb_latitude.Text; }
            set { lb_latitude.Text = value; }
        }
        public string Longitude
        {
            get { return lb_longitude.Text; }
            set { lb_longitude.Text = value; }
        }
        public string Speed
        {
            get { return lb_speed.Text; }
            set { lb_speed.Text = value; }
        }
        public string Distance_to_route
        {
            get { return lb_distance_to_route.Text; }
            set { lb_distance_to_route.Text = value; }
        }
        public string Distance_to_end_route
        {
            get { return lb_distance_to_end_route.Text; }
            set { lb_distance_to_end_route.Text = value; }
        }
        public string Odometer
        {
            get { return lb_odometer.Text; }
            set { lb_odometer.Text = value; }
        }
        public string Code
        {
            get { return lb_code.Text; }
            set { lb_code.Text = value; }
        }
        public string Altitude
        {
            get { return lb_altitude.Text; }
            set { lb_altitude.Text = value; }
        }
        public string Ignition
        {
            get { return lb_ignition.Text; }
            set { lb_ignition.Text = value; }
        }
        public string Batery
        {
            get { return lb_batery.Text; }
            set { lb_batery.Text = value; }
        }
        public string Course
        {
            get { return lb_course.Text; }
            set { lb_course.Text = value; }
        }        
        #endregion
#region  CONSTRUCTORES
        public InfoTracking()
        {
            InitializeComponent();
        }

        public InfoTracking(Entities.TrackingInfo info)
        {
            InitializeComponent();
            Supply_chain_id = info.supply_chain_id.ToString();
            Id = info.id.ToString();
            Plante = info.plante;
            Shipment = info.shipment;
            Transline_name = info.transline_name;
            Transline_id = info.transline_id.ToString();
            Legacy_code = info.legacy_code.ToString();
            Timezone = info.timezone;
            Latitude = info.latitude.ToString();
            Longitude = info.longitude.ToString();
            Speed = info.speed.ToString();
            Distance_to_route = info.distance_to_route.ToString();
            Distance_to_end_route = info.distance_to_end_route.ToString();
            Odometer = info.odometer;
            Code = info.code;
            Altitude = info.altitude;
            Ignition = info.ignition.ToString();
            Batery = info.batery.ToString();
            Course = info.course;

        }
        #endregion
        #region EVENTOS
        private void InfoTracking_Load(object sender, EventArgs e)
        {
            CargarUbicacion();
        }
        #endregion
        #region METODOS
        private async void CargarUbicacion()
        {
            await webView.EnsureCoreWebView2Async(null);
            webView.CoreWebView2.Navigate("https://www.google.com.mx/maps/place/"+Latitude+","+Longitude);
        }
        #endregion
    }
}
