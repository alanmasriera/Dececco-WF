using System;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Ean13Barcode2005
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	partial class frmEan13 : Form
	{
		private Ean13 ean13 = null;

		public frmEan13( )
		{
			InitializeComponent( );
			cboScale.SelectedIndex = 2;
		}
        
		private void CreateEan13( )
		{
			ean13 = new Ean13( );
			ean13.CountryCode = txtCountryCode.Text;
			ean13.ManufacturerCode = txtManufacturerCode.Text;
			ean13.ProductCode = txtProductCode.Text;
			if( txtChecksumDigit.Text.Length > 0 )
				ean13.ChecksumDigit = txtChecksumDigit.Text;
		}

		private void butDraw_Click(object sender, EventArgs e)
		{
			System.Drawing.Graphics g = this.picBarcode.CreateGraphics( );

			g.FillRectangle( new System.Drawing.SolidBrush( System.Drawing.SystemColors.Control ),
				new Rectangle( 0, 0, picBarcode.Width, picBarcode.Height ) );

			CreateEan13( );
			ean13.Scale = (float)Convert.ToDecimal( cboScale.Items [cboScale.SelectedIndex] )/10;
			ean13.DrawEan13Barcode( g, new System.Drawing.Point( 0, 0 ) );

			txtChecksumDigit.Text = ean13.ChecksumDigit;
			g.Dispose( );
		}

		private void butPrint_Click(object sender, EventArgs e)
		{
			System.Drawing.Printing.PrintDocument pd = new System.Drawing.Printing.PrintDocument( );
			pd.PrintPage += new System.Drawing.Printing.PrintPageEventHandler( this.pd_PrintPage );
            
			pd.Print( );
		}

		private void pd_PrintPage( object sender, System.Drawing.Printing.PrintPageEventArgs ev )
		{
			CreateEan13( );
			ean13.Scale = ( float )Convert.ToDecimal( cboScale.Items [cboScale.SelectedIndex] )/10;
			ean13.DrawEan13Barcode( ev.Graphics, new System.Drawing.Point( 0, 0 ) );

            int  X = 20;
            int Y = 20;

            ean13.DrawEan13Barcode(ev.Graphics, new System.Drawing.Point(X , Y ));


			txtChecksumDigit.Text = ean13.ChecksumDigit;

			// Add Code here to print other information.
			ev.Graphics.Dispose( );
		}

		private void butCreateBitmap_Click(object sender, EventArgs e)
		{
			CreateEan13( );
			ean13.Scale = ( float )Convert.ToDecimal( cboScale.Items [cboScale.SelectedIndex] )/10;

			System.Drawing.Bitmap bmp = ean13.CreateBitmap( );
			this.picBarcode.Image = bmp;
		}

        private void cboScale_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmEan13_Load(object sender, EventArgs e)
        {

        }

	}
}

