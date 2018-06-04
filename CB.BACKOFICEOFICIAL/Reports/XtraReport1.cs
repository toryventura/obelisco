using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for XtraReport1
/// </summary>
public class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
{
	private DevExpress.XtraReports.UI.DetailBand Detail;
	private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
	private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
	private XRPageInfo xrPageInfo1;
	private XRPageInfo xrPageInfo2;
	private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
	private ReportHeaderBand reportHeaderBand1;
	private XRLabel xrLabel1;
	private DetailReportBand detailReportBand1;
	private GroupHeaderBand groupHeaderBand1;
	private XRPanel xrPanel1;
	private XRTable xrTable1;
	private XRTableRow xrTableRow1;
	private XRTableCell xrTableCell1;
	private XRTableCell xrTableCell2;
	private XRTableCell xrTableCell3;
	private XRTableCell xrTableCell4;
	private XRTableCell xrTableCell5;
	private XRTableCell xrTableCell6;
	private XRTableCell xrTableCell7;
	private XRTableCell xrTableCell8;
	private XRTableCell xrTableCell9;
	private XRTableCell xrTableCell10;
	private XRTableCell xrTableCell11;
	private XRTableCell xrTableCell12;
	private XRTableCell xrTableCell13;
	private XRTableCell xrTableCell14;
	private XRTableCell xrTableCell15;
	private XRTableCell xrTableCell16;
	private XRTableCell xrTableCell17;
	private XRTableCell xrTableCell18;
	private XRTableCell xrTableCell19;
	private XRTableCell xrTableCell20;
	private XRTableCell xrTableCell21;
	private XRTableCell xrTableCell22;
	private XRTableCell xrTableCell23;
	private XRTableCell xrTableCell24;
	private XRTableCell xrTableCell25;
	private XRTableCell xrTableCell26;
	private XRTableCell xrTableCell27;
	private XRTableCell xrTableCell28;
	private XRTableCell xrTableCell29;
	private XRTableCell xrTableCell30;
	private XRTableCell xrTableCell31;
	private XRTableCell xrTableCell32;
	private XRTableCell xrTableCell33;
	private XRTableCell xrTableCell34;
	private XRTableCell xrTableCell35;
	private DetailBand detailBand1;
	private XRTable xrTable2;
	private XRTableRow xrTableRow2;
	private XRTableCell xrTableCell36;
	private XRTableCell xrTableCell37;
	private XRTableCell xrTableCell38;
	private XRTableCell xrTableCell39;
	private XRTableCell xrTableCell40;
	private XRTableCell xrTableCell41;
	private XRTableCell xrTableCell42;
	private XRTableCell xrTableCell43;
	private XRTableCell xrTableCell44;
	private XRTableCell xrTableCell45;
	private XRTableCell xrTableCell46;
	private XRTableCell xrTableCell47;
	private XRTableCell xrTableCell48;
	private XRTableCell xrTableCell49;
	private XRTableCell xrTableCell50;
	private XRTableCell xrTableCell51;
	private XRTableCell xrTableCell52;
	private XRTableCell xrTableCell53;
	private XRTableCell xrTableCell54;
	private XRTableCell xrTableCell55;
	private XRTableCell xrTableCell56;
	private XRTableCell xrTableCell57;
	private XRTableCell xrTableCell58;
	private XRTableCell xrTableCell59;
	private XRTableCell xrTableCell60;
	private XRTableCell xrTableCell61;
	private XRTableCell xrTableCell62;
	private XRTableCell xrTableCell63;
	private XRTableCell xrTableCell64;
	private XRTableCell xrTableCell65;
	private XRTableCell xrTableCell66;
	private XRTableCell xrTableCell67;
	private XRTableCell xrTableCell68;
	private XRTableCell xrTableCell69;
	private XRTableCell xrTableCell70;
	private XRControlStyle Title;
	private XRControlStyle DetailCaption3;
	private XRControlStyle DetailData3;
	private XRControlStyle DetailData3_Odd;
	private XRControlStyle DetailCaptionBackground3;
	private XRControlStyle PageInfo;
	/// <summary>
	/// Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	public XtraReport1()
	{
		InitializeComponent();
		//
		// TODO: Add constructor logic here
		//
	}

	/// <summary> 
	/// Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
			this.components = new System.ComponentModel.Container();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
			this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.detailReportBand1 = new DevExpress.XtraReports.UI.DetailReportBand();
			this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
			this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
			this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell18 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell22 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell23 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell24 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell25 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell26 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell27 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell28 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell29 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell30 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell31 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell32 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell33 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell34 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell35 = new DevExpress.XtraReports.UI.XRTableCell();
			this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
			this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
			this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell36 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell37 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell38 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell39 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell40 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell41 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell42 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell43 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell44 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell45 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell46 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell47 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell48 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell49 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell50 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell51 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell52 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell53 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell54 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell55 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell56 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell57 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell58 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell59 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell60 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell61 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell62 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell63 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell64 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell65 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell66 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell67 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell68 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell69 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell70 = new DevExpress.XtraReports.UI.XRTableCell();
			this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DetailCaption3 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DetailData3 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DetailCaptionBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
			((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.HeightF = 77.77778F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// TopMargin
			// 
			this.TopMargin.HeightF = 100F;
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// BottomMargin
			// 
			this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.xrPageInfo2});
			this.BottomMargin.HeightF = 100F;
			this.BottomMargin.Name = "BottomMargin";
			this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// objectDataSource1
			// 
			this.objectDataSource1.DataSource = typeof(CB.DATA.USER.OperacionCobranza);
			this.objectDataSource1.Name = "objectDataSource1";
			// 
			// xrPageInfo1
			// 
			this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(4F, 4F);
			this.xrPageInfo1.Name = "xrPageInfo1";
			this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.xrPageInfo1.SizeF = new System.Drawing.SizeF(317F, 23F);
			this.xrPageInfo1.StyleName = "PageInfo";
			// 
			// xrPageInfo2
			// 
			this.xrPageInfo2.Format = "Página {0} de {1}";
			this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(329F, 4F);
			this.xrPageInfo2.Name = "xrPageInfo2";
			this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrPageInfo2.SizeF = new System.Drawing.SizeF(317F, 23F);
			this.xrPageInfo2.StyleName = "PageInfo";
			this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			// 
			// reportHeaderBand1
			// 
			this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
			this.reportHeaderBand1.HeightF = 60F;
			this.reportHeaderBand1.Name = "reportHeaderBand1";
			// 
			// xrLabel1
			// 
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(4F, 4F);
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(642F, 26F);
			this.xrLabel1.StyleName = "Title";
			this.xrLabel1.Text = "Reporte";
			// 
			// detailReportBand1
			// 
			this.detailReportBand1.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.groupHeaderBand1,
            this.detailBand1});
			this.detailReportBand1.DataMember = "AsignacionCliente.OperacionCobranzas";
			this.detailReportBand1.DataSource = this.objectDataSource1;
			this.detailReportBand1.Level = 0;
			this.detailReportBand1.Name = "detailReportBand1";
			// 
			// groupHeaderBand1
			// 
			this.groupHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
			this.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
			this.groupHeaderBand1.HeightF = 48F;
			this.groupHeaderBand1.Name = "groupHeaderBand1";
			// 
			// xrPanel1
			// 
			this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
			this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.xrPanel1.Name = "xrPanel1";
			this.xrPanel1.SizeF = new System.Drawing.SizeF(650F, 48F);
			this.xrPanel1.StyleName = "DetailCaptionBackground3";
			// 
			// xrTable1
			// 
			this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 20F);
			this.xrTable1.Name = "xrTable1";
			this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
			this.xrTable1.SizeF = new System.Drawing.SizeF(650F, 28F);
			// 
			// xrTableRow1
			// 
			this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9,
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell12,
            this.xrTableCell13,
            this.xrTableCell14,
            this.xrTableCell15,
            this.xrTableCell16,
            this.xrTableCell17,
            this.xrTableCell18,
            this.xrTableCell19,
            this.xrTableCell20,
            this.xrTableCell21,
            this.xrTableCell22,
            this.xrTableCell23,
            this.xrTableCell24,
            this.xrTableCell25,
            this.xrTableCell26,
            this.xrTableCell27,
            this.xrTableCell28,
            this.xrTableCell29,
            this.xrTableCell30,
            this.xrTableCell31,
            this.xrTableCell32,
            this.xrTableCell33,
            this.xrTableCell34,
            this.xrTableCell35});
			this.xrTableRow1.Name = "xrTableRow1";
			this.xrTableRow1.Weight = 1D;
			// 
			// xrTableCell1
			// 
			this.xrTableCell1.Name = "xrTableCell1";
			this.xrTableCell1.StyleName = "DetailCaption3";
			this.xrTableCell1.StylePriority.UseTextAlignment = false;
			this.xrTableCell1.Text = "operacion Cobranza ID";
			this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell1.Weight = 0.028461068960336539D;
			// 
			// xrTableCell2
			// 
			this.xrTableCell2.Name = "xrTableCell2";
			this.xrTableCell2.StyleName = "DetailCaption3";
			this.xrTableCell2.Text = "Comentario";
			this.xrTableCell2.Weight = 0.015653588221623348D;
			// 
			// xrTableCell3
			// 
			this.xrTableCell3.Name = "xrTableCell3";
			this.xrTableCell3.StyleName = "DetailCaption3";
			this.xrTableCell3.Text = "Telefono Alternativo";
			this.xrTableCell3.Weight = 0.025614961477426382D;
			// 
			// xrTableCell4
			// 
			this.xrTableCell4.Name = "xrTableCell4";
			this.xrTableCell4.StyleName = "DetailCaption3";
			this.xrTableCell4.Text = "Fecha Compromiso";
			this.xrTableCell4.Weight = 0.023988616649921125D;
			// 
			// xrTableCell5
			// 
			this.xrTableCell5.Name = "xrTableCell5";
			this.xrTableCell5.StyleName = "DetailCaption3";
			this.xrTableCell5.Text = "Causal Mora Ant";
			this.xrTableCell5.Weight = 0.020939215146578274D;
			// 
			// xrTableCell6
			// 
			this.xrTableCell6.Name = "xrTableCell6";
			this.xrTableCell6.StyleName = "DetailCaption3";
			this.xrTableCell6.Text = "Fe Cre";
			this.xrTableCell6.Weight = 0.009758080702561598D;
			// 
			// xrTableCell7
			// 
			this.xrTableCell7.Name = "xrTableCell7";
			this.xrTableCell7.StyleName = "DetailCaption3";
			this.xrTableCell7.Text = "Fe Mod";
			this.xrTableCell7.Weight = 0.010774547870342549D;
			// 
			// xrTableCell8
			// 
			this.xrTableCell8.Name = "xrTableCell8";
			this.xrTableCell8.StyleName = "DetailCaption3";
			this.xrTableCell8.Text = "Usr Cre";
			this.xrTableCell8.Weight = 0.010774547870342549D;
			// 
			// xrTableCell9
			// 
			this.xrTableCell9.Name = "xrTableCell9";
			this.xrTableCell9.StyleName = "DetailCaption3";
			this.xrTableCell9.Text = "Usr Mod";
			this.xrTableCell9.Weight = 0.011791014304527869D;
			// 
			// xrTableCell10
			// 
			this.xrTableCell10.Name = "xrTableCell10";
			this.xrTableCell10.StyleName = "DetailCaption3";
			this.xrTableCell10.Text = "asignacion Cliente ID";
			this.xrTableCell10.Weight = 0.026834722665640024D;
			// 
			// xrTableCell11
			// 
			this.xrTableCell11.Name = "xrTableCell11";
			this.xrTableCell11.StyleName = "DetailCaption3";
			this.xrTableCell11.Text = "causal Mora ID";
			this.xrTableCell11.Weight = 0.019516161405123196D;
			// 
			// xrTableCell12
			// 
			this.xrTableCell12.Name = "xrTableCell12";
			this.xrTableCell12.StyleName = "DetailCaption3";
			this.xrTableCell12.Text = "compromiso Pago ID";
			this.xrTableCell12.Weight = 0.026224843538724459D;
			// 
			// xrTableCell13
			// 
			this.xrTableCell13.Name = "xrTableCell13";
			this.xrTableCell13.StyleName = "DetailCaption3";
			this.xrTableCell13.Text = "tipo Gestion ID";
			this.xrTableCell13.Weight = 0.019719455425555889D;
			// 
			// xrTableCell14
			// 
			this.xrTableCell14.Name = "xrTableCell14";
			this.xrTableCell14.StyleName = "DetailCaption3";
			this.xrTableCell14.Text = "presencia Cliente ID";
			this.xrTableCell14.Weight = 0.025614961477426382D;
			// 
			// xrTableCell15
			// 
			this.xrTableCell15.Name = "xrTableCell15";
			this.xrTableCell15.StyleName = "DetailCaption3";
			this.xrTableCell15.Text = "probalidad Pago ID";
			this.xrTableCell15.Weight = 0.024395203223595251D;
			// 
			// xrTableCell16
			// 
			this.xrTableCell16.Name = "xrTableCell16";
			this.xrTableCell16.StyleName = "DetailCaption3";
			this.xrTableCell16.StylePriority.UseTextAlignment = false;
			this.xrTableCell16.Text = "Asignacion Cliente asignacion Cliente ID";
			this.xrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell16.Weight = 0.048383818406325121D;
			// 
			// xrTableCell17
			// 
			this.xrTableCell17.Name = "xrTableCell17";
			this.xrTableCell17.StyleName = "DetailCaption3";
			this.xrTableCell17.Text = "Asignacion Cliente Cod Cliente";
			this.xrTableCell17.Weight = 0.036999391409067009D;
			// 
			// xrTableCell18
			// 
			this.xrTableCell18.Name = "xrTableCell18";
			this.xrTableCell18.StyleName = "DetailCaption3";
			this.xrTableCell18.Text = "Asignacion Cliente Fecha Asignacion";
			this.xrTableCell18.Weight = 0.043708070608285757D;
			// 
			// xrTableCell19
			// 
			this.xrTableCell19.Name = "xrTableCell19";
			this.xrTableCell19.StyleName = "DetailCaption3";
			this.xrTableCell19.Text = "Asignacion Cliente Usr Cre";
			this.xrTableCell19.Weight = 0.032526937631460334D;
			// 
			// xrTableCell20
			// 
			this.xrTableCell20.Name = "xrTableCell20";
			this.xrTableCell20.StyleName = "DetailCaption3";
			this.xrTableCell20.Text = "Asignacion Cliente Usr Mod";
			this.xrTableCell20.Weight = 0.033340110778808593D;
			// 
			// xrTableCell21
			// 
			this.xrTableCell21.Name = "xrTableCell21";
			this.xrTableCell21.StyleName = "DetailCaption3";
			this.xrTableCell21.Text = "Asignacion Cliente Fe Cre";
			this.xrTableCell21.Weight = 0.031307176443246695D;
			// 
			// xrTableCell22
			// 
			this.xrTableCell22.Name = "xrTableCell22";
			this.xrTableCell22.StyleName = "DetailCaption3";
			this.xrTableCell22.Text = "Asignacion Cliente Fecha Mod";
			this.xrTableCell22.Weight = 0.03618621826171875D;
			// 
			// xrTableCell23
			// 
			this.xrTableCell23.Name = "xrTableCell23";
			this.xrTableCell23.StyleName = "DetailCaption3";
			this.xrTableCell23.Text = "Asignacion Cliente Cod Usuario";
			this.xrTableCell23.Weight = 0.037812564556415261D;
			// 
			// xrTableCell24
			// 
			this.xrTableCell24.Name = "xrTableCell24";
			this.xrTableCell24.StyleName = "DetailCaption3";
			this.xrTableCell24.Text = "Asignacion Cliente Estado";
			this.xrTableCell24.Weight = 0.031713764484112082D;
			// 
			// xrTableCell25
			// 
			this.xrTableCell25.Name = "xrTableCell25";
			this.xrTableCell25.StyleName = "DetailCaption3";
			this.xrTableCell25.Text = "Asignacion Cliente Fecha Reasignacion";
			this.xrTableCell25.Weight = 0.046554178091195914D;
			// 
			// xrTableCell26
			// 
			this.xrTableCell26.Name = "xrTableCell26";
			this.xrTableCell26.StyleName = "DetailCaption3";
			this.xrTableCell26.Text = "Asignacion Cliente Periodo";
			this.xrTableCell26.Weight = 0.032730231651893031D;
			// 
			// xrTableCell27
			// 
			this.xrTableCell27.Name = "xrTableCell27";
			this.xrTableCell27.StyleName = "DetailCaption3";
			this.xrTableCell27.Text = "Asignacion Cliente Codigo";
			this.xrTableCell27.Weight = 0.031917055570162257D;
			// 
			// xrTableCell28
			// 
			this.xrTableCell28.Name = "xrTableCell28";
			this.xrTableCell28.StyleName = "DetailCaption3";
			this.xrTableCell28.Text = "Causal Mora Nombre";
			this.xrTableCell28.Weight = 0.026224843538724459D;
			// 
			// xrTableCell29
			// 
			this.xrTableCell29.Name = "xrTableCell29";
			this.xrTableCell29.StyleName = "DetailCaption3";
			this.xrTableCell29.StylePriority.UseTextAlignment = false;
			this.xrTableCell29.Text = "Causal Mora causal Mora ID";
			this.xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell29.Weight = 0.034153283926156852D;
			// 
			// xrTableCell30
			// 
			this.xrTableCell30.Name = "xrTableCell30";
			this.xrTableCell30.StyleName = "DetailCaption3";
			this.xrTableCell30.StylePriority.UseTextAlignment = false;
			this.xrTableCell30.Text = "Compromiso Pago compromiso Pago ID";
			this.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell30.Weight = 0.047367351238544173D;
			// 
			// xrTableCell31
			// 
			this.xrTableCell31.Name = "xrTableCell31";
			this.xrTableCell31.StyleName = "DetailCaption3";
			this.xrTableCell31.Text = "Compromiso Pago Nombre";
			this.xrTableCell31.Weight = 0.032730231651893031D;
			// 
			// xrTableCell32
			// 
			this.xrTableCell32.Name = "xrTableCell32";
			this.xrTableCell32.StyleName = "DetailCaption3";
			this.xrTableCell32.StylePriority.UseTextAlignment = false;
			this.xrTableCell32.Text = "Probalidad Pago ID";
			this.xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell32.Weight = 0.02459849577683669D;
			// 
			// xrTableCell33
			// 
			this.xrTableCell33.Name = "xrTableCell33";
			this.xrTableCell33.StyleName = "DetailCaption3";
			this.xrTableCell33.Text = "Probalidad Pago Nombre";
			this.xrTableCell33.Weight = 0.03069729731633113D;
			// 
			// xrTableCell34
			// 
			this.xrTableCell34.Name = "xrTableCell34";
			this.xrTableCell34.StyleName = "DetailCaption3";
			this.xrTableCell34.StylePriority.UseTextAlignment = false;
			this.xrTableCell34.Text = "Tipo Gestion tipo Gestion ID";
			this.xrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell34.Weight = 0.034559869032639724D;
			// 
			// xrTableCell35
			// 
			this.xrTableCell35.Name = "xrTableCell35";
			this.xrTableCell35.StyleName = "DetailCaption3";
			this.xrTableCell35.Text = "Tipo Gestion Nombre";
			this.xrTableCell35.Weight = 0.026428137559157152D;
			// 
			// detailBand1
			// 
			this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
			this.detailBand1.HeightF = 25F;
			this.detailBand1.Name = "detailBand1";
			// 
			// xrTable2
			// 
			this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.xrTable2.Name = "xrTable2";
			this.xrTable2.OddStyleName = "DetailData3_Odd";
			this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
			this.xrTable2.SizeF = new System.Drawing.SizeF(650F, 25F);
			// 
			// xrTableRow2
			// 
			this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell36,
            this.xrTableCell37,
            this.xrTableCell38,
            this.xrTableCell39,
            this.xrTableCell40,
            this.xrTableCell41,
            this.xrTableCell42,
            this.xrTableCell43,
            this.xrTableCell44,
            this.xrTableCell45,
            this.xrTableCell46,
            this.xrTableCell47,
            this.xrTableCell48,
            this.xrTableCell49,
            this.xrTableCell50,
            this.xrTableCell51,
            this.xrTableCell52,
            this.xrTableCell53,
            this.xrTableCell54,
            this.xrTableCell55,
            this.xrTableCell56,
            this.xrTableCell57,
            this.xrTableCell58,
            this.xrTableCell59,
            this.xrTableCell60,
            this.xrTableCell61,
            this.xrTableCell62,
            this.xrTableCell63,
            this.xrTableCell64,
            this.xrTableCell65,
            this.xrTableCell66,
            this.xrTableCell67,
            this.xrTableCell68,
            this.xrTableCell69,
            this.xrTableCell70});
			this.xrTableRow2.Name = "xrTableRow2";
			this.xrTableRow2.Weight = 11.5D;
			// 
			// xrTableCell36
			// 
			this.xrTableCell36.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.operacionCobranzaID")});
			this.xrTableCell36.Name = "xrTableCell36";
			this.xrTableCell36.StyleName = "DetailData3";
			this.xrTableCell36.StylePriority.UseTextAlignment = false;
			this.xrTableCell36.Text = "xrTableCell36";
			this.xrTableCell36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell36.Weight = 0.028461068960336539D;
			// 
			// xrTableCell37
			// 
			this.xrTableCell37.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.Comentario")});
			this.xrTableCell37.Name = "xrTableCell37";
			this.xrTableCell37.StyleName = "DetailData3";
			this.xrTableCell37.Text = "xrTableCell37";
			this.xrTableCell37.Weight = 0.015653588221623348D;
			// 
			// xrTableCell38
			// 
			this.xrTableCell38.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.TelefonoAlternativo")});
			this.xrTableCell38.Name = "xrTableCell38";
			this.xrTableCell38.StyleName = "DetailData3";
			this.xrTableCell38.Text = "xrTableCell38";
			this.xrTableCell38.Weight = 0.025614961477426382D;
			// 
			// xrTableCell39
			// 
			this.xrTableCell39.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.FechaCompromiso")});
			this.xrTableCell39.Name = "xrTableCell39";
			this.xrTableCell39.StyleName = "DetailData3";
			this.xrTableCell39.Text = "xrTableCell39";
			this.xrTableCell39.Weight = 0.023988616649921125D;
			// 
			// xrTableCell40
			// 
			this.xrTableCell40.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.CausalMoraAnt")});
			this.xrTableCell40.Name = "xrTableCell40";
			this.xrTableCell40.StyleName = "DetailData3";
			this.xrTableCell40.Text = "xrTableCell40";
			this.xrTableCell40.Weight = 0.020939215146578274D;
			// 
			// xrTableCell41
			// 
			this.xrTableCell41.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.FeCre")});
			this.xrTableCell41.Name = "xrTableCell41";
			this.xrTableCell41.StyleName = "DetailData3";
			this.xrTableCell41.Text = "xrTableCell41";
			this.xrTableCell41.Weight = 0.009758080702561598D;
			// 
			// xrTableCell42
			// 
			this.xrTableCell42.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.FeMod")});
			this.xrTableCell42.Name = "xrTableCell42";
			this.xrTableCell42.StyleName = "DetailData3";
			this.xrTableCell42.Text = "xrTableCell42";
			this.xrTableCell42.Weight = 0.010774547870342549D;
			// 
			// xrTableCell43
			// 
			this.xrTableCell43.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.UsrCre")});
			this.xrTableCell43.Name = "xrTableCell43";
			this.xrTableCell43.StyleName = "DetailData3";
			this.xrTableCell43.Text = "xrTableCell43";
			this.xrTableCell43.Weight = 0.010774547870342549D;
			// 
			// xrTableCell44
			// 
			this.xrTableCell44.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.UsrMod")});
			this.xrTableCell44.Name = "xrTableCell44";
			this.xrTableCell44.StyleName = "DetailData3";
			this.xrTableCell44.Text = "xrTableCell44";
			this.xrTableCell44.Weight = 0.011791014304527869D;
			// 
			// xrTableCell45
			// 
			this.xrTableCell45.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.asignacionClienteID")});
			this.xrTableCell45.Name = "xrTableCell45";
			this.xrTableCell45.StyleName = "DetailData3";
			this.xrTableCell45.Text = "xrTableCell45";
			this.xrTableCell45.Weight = 0.026834722665640024D;
			// 
			// xrTableCell46
			// 
			this.xrTableCell46.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.causalMoraID")});
			this.xrTableCell46.Name = "xrTableCell46";
			this.xrTableCell46.StyleName = "DetailData3";
			this.xrTableCell46.Text = "xrTableCell46";
			this.xrTableCell46.Weight = 0.019516161405123196D;
			// 
			// xrTableCell47
			// 
			this.xrTableCell47.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.compromisoPagoID")});
			this.xrTableCell47.Name = "xrTableCell47";
			this.xrTableCell47.StyleName = "DetailData3";
			this.xrTableCell47.Text = "xrTableCell47";
			this.xrTableCell47.Weight = 0.026224843538724459D;
			// 
			// xrTableCell48
			// 
			this.xrTableCell48.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.tipoGestionID")});
			this.xrTableCell48.Name = "xrTableCell48";
			this.xrTableCell48.StyleName = "DetailData3";
			this.xrTableCell48.Text = "xrTableCell48";
			this.xrTableCell48.Weight = 0.019719455425555889D;
			// 
			// xrTableCell49
			// 
			this.xrTableCell49.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.presenciaClienteID")});
			this.xrTableCell49.Name = "xrTableCell49";
			this.xrTableCell49.StyleName = "DetailData3";
			this.xrTableCell49.Text = "xrTableCell49";
			this.xrTableCell49.Weight = 0.025614961477426382D;
			// 
			// xrTableCell50
			// 
			this.xrTableCell50.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.probalidadPagoID")});
			this.xrTableCell50.Name = "xrTableCell50";
			this.xrTableCell50.StyleName = "DetailData3";
			this.xrTableCell50.Text = "xrTableCell50";
			this.xrTableCell50.Weight = 0.024395203223595251D;
			// 
			// xrTableCell51
			// 
			this.xrTableCell51.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.AsignacionCliente.asignacionClienteID")});
			this.xrTableCell51.Name = "xrTableCell51";
			this.xrTableCell51.StyleName = "DetailData3";
			this.xrTableCell51.StylePriority.UseTextAlignment = false;
			this.xrTableCell51.Text = "xrTableCell51";
			this.xrTableCell51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell51.Weight = 0.048383818406325121D;
			// 
			// xrTableCell52
			// 
			this.xrTableCell52.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.AsignacionCliente.CodCliente")});
			this.xrTableCell52.Name = "xrTableCell52";
			this.xrTableCell52.StyleName = "DetailData3";
			this.xrTableCell52.Text = "xrTableCell52";
			this.xrTableCell52.Weight = 0.036999391409067009D;
			// 
			// xrTableCell53
			// 
			this.xrTableCell53.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.AsignacionCliente.FechaAsignacion")});
			this.xrTableCell53.Name = "xrTableCell53";
			this.xrTableCell53.StyleName = "DetailData3";
			this.xrTableCell53.Text = "xrTableCell53";
			this.xrTableCell53.Weight = 0.043708070608285757D;
			// 
			// xrTableCell54
			// 
			this.xrTableCell54.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.AsignacionCliente.UsrCre")});
			this.xrTableCell54.Name = "xrTableCell54";
			this.xrTableCell54.StyleName = "DetailData3";
			this.xrTableCell54.Text = "xrTableCell54";
			this.xrTableCell54.Weight = 0.032526937631460334D;
			// 
			// xrTableCell55
			// 
			this.xrTableCell55.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.AsignacionCliente.UsrMod")});
			this.xrTableCell55.Name = "xrTableCell55";
			this.xrTableCell55.StyleName = "DetailData3";
			this.xrTableCell55.Text = "xrTableCell55";
			this.xrTableCell55.Weight = 0.033340110778808593D;
			// 
			// xrTableCell56
			// 
			this.xrTableCell56.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.AsignacionCliente.FeCre")});
			this.xrTableCell56.Name = "xrTableCell56";
			this.xrTableCell56.StyleName = "DetailData3";
			this.xrTableCell56.Text = "xrTableCell56";
			this.xrTableCell56.Weight = 0.031307176443246695D;
			// 
			// xrTableCell57
			// 
			this.xrTableCell57.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.AsignacionCliente.FechaMod")});
			this.xrTableCell57.Name = "xrTableCell57";
			this.xrTableCell57.StyleName = "DetailData3";
			this.xrTableCell57.Text = "xrTableCell57";
			this.xrTableCell57.Weight = 0.03618621826171875D;
			// 
			// xrTableCell58
			// 
			this.xrTableCell58.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.AsignacionCliente.CodUsuario")});
			this.xrTableCell58.Name = "xrTableCell58";
			this.xrTableCell58.StyleName = "DetailData3";
			this.xrTableCell58.Text = "xrTableCell58";
			this.xrTableCell58.Weight = 0.037812564556415261D;
			// 
			// xrTableCell59
			// 
			this.xrTableCell59.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.AsignacionCliente.Estado")});
			this.xrTableCell59.Name = "xrTableCell59";
			this.xrTableCell59.StyleName = "DetailData3";
			this.xrTableCell59.Text = "xrTableCell59";
			this.xrTableCell59.Weight = 0.031713764484112082D;
			// 
			// xrTableCell60
			// 
			this.xrTableCell60.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.AsignacionCliente.FechaReasignacion")});
			this.xrTableCell60.Name = "xrTableCell60";
			this.xrTableCell60.StyleName = "DetailData3";
			this.xrTableCell60.Text = "xrTableCell60";
			this.xrTableCell60.Weight = 0.046554178091195914D;
			// 
			// xrTableCell61
			// 
			this.xrTableCell61.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.AsignacionCliente.Periodo")});
			this.xrTableCell61.Name = "xrTableCell61";
			this.xrTableCell61.StyleName = "DetailData3";
			this.xrTableCell61.Text = "xrTableCell61";
			this.xrTableCell61.Weight = 0.032730231651893031D;
			// 
			// xrTableCell62
			// 
			this.xrTableCell62.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.AsignacionCliente.Codigo")});
			this.xrTableCell62.Name = "xrTableCell62";
			this.xrTableCell62.StyleName = "DetailData3";
			this.xrTableCell62.Text = "xrTableCell62";
			this.xrTableCell62.Weight = 0.031917055570162257D;
			// 
			// xrTableCell63
			// 
			this.xrTableCell63.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.CausalMora.Nombre")});
			this.xrTableCell63.Name = "xrTableCell63";
			this.xrTableCell63.StyleName = "DetailData3";
			this.xrTableCell63.Text = "xrTableCell63";
			this.xrTableCell63.Weight = 0.026224843538724459D;
			// 
			// xrTableCell64
			// 
			this.xrTableCell64.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.CausalMora.causalMoraID")});
			this.xrTableCell64.Name = "xrTableCell64";
			this.xrTableCell64.StyleName = "DetailData3";
			this.xrTableCell64.StylePriority.UseTextAlignment = false;
			this.xrTableCell64.Text = "xrTableCell64";
			this.xrTableCell64.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell64.Weight = 0.034153283926156852D;
			// 
			// xrTableCell65
			// 
			this.xrTableCell65.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.CompromisoPago.compromisoPagoID")});
			this.xrTableCell65.Name = "xrTableCell65";
			this.xrTableCell65.StyleName = "DetailData3";
			this.xrTableCell65.StylePriority.UseTextAlignment = false;
			this.xrTableCell65.Text = "xrTableCell65";
			this.xrTableCell65.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell65.Weight = 0.047367351238544173D;
			// 
			// xrTableCell66
			// 
			this.xrTableCell66.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.CompromisoPago.Nombre")});
			this.xrTableCell66.Name = "xrTableCell66";
			this.xrTableCell66.StyleName = "DetailData3";
			this.xrTableCell66.Text = "xrTableCell66";
			this.xrTableCell66.Weight = 0.032730231651893031D;
			// 
			// xrTableCell67
			// 
			this.xrTableCell67.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.ProbalidadPago.ID")});
			this.xrTableCell67.Name = "xrTableCell67";
			this.xrTableCell67.StyleName = "DetailData3";
			this.xrTableCell67.StylePriority.UseTextAlignment = false;
			this.xrTableCell67.Text = "xrTableCell67";
			this.xrTableCell67.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell67.Weight = 0.02459849577683669D;
			// 
			// xrTableCell68
			// 
			this.xrTableCell68.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.ProbalidadPago.Nombre")});
			this.xrTableCell68.Name = "xrTableCell68";
			this.xrTableCell68.StyleName = "DetailData3";
			this.xrTableCell68.Text = "xrTableCell68";
			this.xrTableCell68.Weight = 0.03069729731633113D;
			// 
			// xrTableCell69
			// 
			this.xrTableCell69.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.TipoGestion.tipoGestionID")});
			this.xrTableCell69.Name = "xrTableCell69";
			this.xrTableCell69.StyleName = "DetailData3";
			this.xrTableCell69.StylePriority.UseTextAlignment = false;
			this.xrTableCell69.Text = "xrTableCell69";
			this.xrTableCell69.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
			this.xrTableCell69.Weight = 0.034559869032639724D;
			// 
			// xrTableCell70
			// 
			this.xrTableCell70.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "AsignacionCliente.OperacionCobranzas.TipoGestion.Nombre")});
			this.xrTableCell70.Name = "xrTableCell70";
			this.xrTableCell70.StyleName = "DetailData3";
			this.xrTableCell70.Text = "xrTableCell70";
			this.xrTableCell70.Weight = 0.026428128756009615D;
			// 
			// Title
			// 
			this.Title.BackColor = System.Drawing.Color.Transparent;
			this.Title.BorderColor = System.Drawing.Color.Black;
			this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.Title.BorderWidth = 1F;
			this.Title.Font = new System.Drawing.Font("Tahoma", 14F);
			this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.Title.Name = "Title";
			// 
			// DetailCaption3
			// 
			this.DetailCaption3.BackColor = System.Drawing.Color.Transparent;
			this.DetailCaption3.BorderColor = System.Drawing.Color.Transparent;
			this.DetailCaption3.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.DetailCaption3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.DetailCaption3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.DetailCaption3.Name = "DetailCaption3";
			this.DetailCaption3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
			this.DetailCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// DetailData3
			// 
			this.DetailData3.Font = new System.Drawing.Font("Tahoma", 8F);
			this.DetailData3.ForeColor = System.Drawing.Color.Black;
			this.DetailData3.Name = "DetailData3";
			this.DetailData3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
			this.DetailData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// DetailData3_Odd
			// 
			this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
			this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
			this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.DetailData3_Odd.BorderWidth = 1F;
			this.DetailData3_Odd.Font = new System.Drawing.Font("Tahoma", 8F);
			this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
			this.DetailData3_Odd.Name = "DetailData3_Odd";
			this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
			this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// DetailCaptionBackground3
			// 
			this.DetailCaptionBackground3.BackColor = System.Drawing.Color.Transparent;
			this.DetailCaptionBackground3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
			this.DetailCaptionBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Top;
			this.DetailCaptionBackground3.BorderWidth = 2F;
			this.DetailCaptionBackground3.Name = "DetailCaptionBackground3";
			// 
			// PageInfo
			// 
			this.PageInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
			this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
			this.PageInfo.Name = "PageInfo";
			this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			// 
			// XtraReport1
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.reportHeaderBand1,
            this.detailReportBand1});
			this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
			this.DataSource = this.objectDataSource1;
			this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption3,
            this.DetailData3,
            this.DetailData3_Odd,
            this.DetailCaptionBackground3,
            this.PageInfo});
			this.Version = "17.1";
			((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion
}
