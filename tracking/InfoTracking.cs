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
    {/*
         public long? supply_chain_id { get; set; }
        public long? id { get; set; }
        public string? plante { get; set; }
        public string? shipment { get; set; }
        public string? transline_name { get; set; }
        public int? transline_id { get; set; }
        public int? legacy_code { get; set; }
        public string? timezone { get; set; }
        public double? latitude { get; set; }
        public double? longitude { get; set; }
        public int? speed { get; set; }
        public int? distance_to_route { get; set; }
        public int? distance_to_end_route { get; set; }
        public string? odometer { get; set; }
        public string? code { get; set; }
        public string? altitude { get; set; }
        public int? ignition { get; set; }
        public int? batery { get; set; }
        public string? course { get; set; }
         */
        #region VARIABLES PRIVADAS
        private long supply_chain_id;
        private long id;
        private string plante;
        private string shipment;
        private string transline_name;
        private int transline_id;
        private int legacy_code;
        private string timezone;
        private double latitude;
        private double longitude;
        private int speed;
        private int distance_to_route;
        private int distance_to_end_route;
        private string odometer;
        private string code;
        private string altitude;
        private int ignition;
        private int batery;
        private string course;
        #endregion
        
        public InfoTracking()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
