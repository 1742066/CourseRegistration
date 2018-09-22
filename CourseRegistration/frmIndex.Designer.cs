namespace CourseRegistration
{
    partial class frmIndex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnCreateMajors = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditMajoirs = new DevExpress.XtraBars.BarButtonItem();
            this.btnCreateSubjects = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditSubjects = new DevExpress.XtraBars.BarButtonItem();
            this.CreateThematic = new DevExpress.XtraBars.BarButtonItem();
            this.EditThematic = new DevExpress.XtraBars.BarButtonItem();
            this.CreateGroup = new DevExpress.XtraBars.BarButtonItem();
            this.EditGroup = new DevExpress.XtraBars.BarButtonItem();
            this.OK = new DevExpress.XtraBars.BarButtonItem();
            this.btnOpenThematic = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditOpenThematic = new DevExpress.XtraBars.BarButtonItem();
            this.btnJoinGroup = new DevExpress.XtraBars.BarButtonItem();
            this.btnCreateAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditAccount = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup13 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.txtAccountCode = new System.Windows.Forms.Label();
            this.txtAccountType = new System.Windows.Forms.Label();
            this.ribbonPageGroup14 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnPC = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnCreateMajors,
            this.btnEditMajoirs,
            this.btnCreateSubjects,
            this.btnEditSubjects,
            this.CreateThematic,
            this.EditThematic,
            this.CreateGroup,
            this.EditGroup,
            this.OK,
            this.btnOpenThematic,
            this.btnEditOpenThematic,
            this.btnJoinGroup,
            this.btnCreateAccount,
            this.btnEditAccount,
            this.btnPC});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 18;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5});
            this.ribbon.Size = new System.Drawing.Size(745, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnCreateMajors
            // 
            this.btnCreateMajors.Caption = "Tạo mới";
            this.btnCreateMajors.Id = 1;
            this.btnCreateMajors.Name = "btnCreateMajors";
            this.btnCreateMajors.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.btnCreateMajors.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateMajors_ItemClick);
            // 
            // btnEditMajoirs
            // 
            this.btnEditMajoirs.Caption = "Chỉnh sửa";
            this.btnEditMajoirs.Id = 3;
            this.btnEditMajoirs.Name = "btnEditMajoirs";
            this.btnEditMajoirs.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditMajoirs_ItemClick);
            // 
            // btnCreateSubjects
            // 
            this.btnCreateSubjects.Caption = "Tạo mới";
            this.btnCreateSubjects.Id = 4;
            this.btnCreateSubjects.Name = "btnCreateSubjects";
            this.btnCreateSubjects.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateSubjects_ItemClick);
            // 
            // btnEditSubjects
            // 
            this.btnEditSubjects.Caption = "Chỉnh sửa";
            this.btnEditSubjects.Id = 6;
            this.btnEditSubjects.Name = "btnEditSubjects";
            this.btnEditSubjects.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditSubjects_ItemClick);
            // 
            // CreateThematic
            // 
            this.CreateThematic.Caption = "Tạo mới";
            this.CreateThematic.Id = 7;
            this.CreateThematic.Name = "CreateThematic";
            this.CreateThematic.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CreateThematic_ItemClick);
            // 
            // EditThematic
            // 
            this.EditThematic.Caption = "Chỉnh sửa";
            this.EditThematic.Id = 8;
            this.EditThematic.Name = "EditThematic";
            this.EditThematic.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditThematic_ItemClick);
            // 
            // CreateGroup
            // 
            this.CreateGroup.Caption = "Tạo mới";
            this.CreateGroup.Id = 9;
            this.CreateGroup.Name = "CreateGroup";
            this.CreateGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CreateGroup_ItemClick);
            // 
            // EditGroup
            // 
            this.EditGroup.Caption = "Chỉnh sửa";
            this.EditGroup.Id = 10;
            this.EditGroup.Name = "EditGroup";
            this.EditGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditGroup_ItemClick);
            // 
            // OK
            // 
            this.OK.Caption = "barButtonItem1";
            this.OK.Id = 11;
            this.OK.Name = "OK";
            // 
            // btnOpenThematic
            // 
            this.btnOpenThematic.Caption = "Mở chuyên đề";
            this.btnOpenThematic.Id = 12;
            this.btnOpenThematic.Name = "btnOpenThematic";
            this.btnOpenThematic.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOpenThematic_ItemClick);
            // 
            // btnEditOpenThematic
            // 
            this.btnEditOpenThematic.Caption = "Chỉnh sửa chuyên đề mở";
            this.btnEditOpenThematic.Id = 13;
            this.btnEditOpenThematic.Name = "btnEditOpenThematic";
            this.btnEditOpenThematic.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditOpenThematic_ItemClick);
            // 
            // btnJoinGroup
            // 
            this.btnJoinGroup.Caption = "Gia nhập nhóm";
            this.btnJoinGroup.Id = 14;
            this.btnJoinGroup.Name = "btnJoinGroup";
            this.btnJoinGroup.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnJoinGroup_ItemClick);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Caption = "Tạo mới tài khoản";
            this.btnCreateAccount.Id = 15;
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateAccount_ItemClick);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Caption = "Chỉnh sửa tài khoản";
            this.btnEditAccount.Id = 16;
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEditAccount_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản lý Ngành";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCreateMajors);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.ShowCaptionButton = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnEditMajoirs);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản lý môn học";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.AllowTextClipping = false;
            this.ribbonPageGroup3.ItemLinks.Add(this.btnCreateSubjects);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnEditSubjects);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup9,
            this.ribbonPageGroup10,
            this.ribbonPageGroup14});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Quản lý chuyên đề";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.CreateThematic);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.EditThematic);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnOpenThematic);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.btnEditOpenThematic);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7,
            this.ribbonPageGroup8,
            this.ribbonPageGroup11});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Quản lý nhóm";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.CreateGroup);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.EditGroup);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.btnJoinGroup);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup12,
            this.ribbonPageGroup13});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Tài khoản";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.ItemLinks.Add(this.btnCreateAccount);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            // 
            // ribbonPageGroup13
            // 
            this.ribbonPageGroup13.ItemLinks.Add(this.btnEditAccount);
            this.ribbonPageGroup13.Name = "ribbonPageGroup13";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 418);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(745, 31);
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.RootContainer.Element = null;
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
            // 
            // txtAccountCode
            // 
            this.txtAccountCode.AutoSize = true;
            this.txtAccountCode.Location = new System.Drawing.Point(710, 35);
            this.txtAccountCode.Name = "txtAccountCode";
            this.txtAccountCode.Size = new System.Drawing.Size(35, 13);
            this.txtAccountCode.TabIndex = 3;
            this.txtAccountCode.Text = "label1";
            this.txtAccountCode.Visible = false;
            // 
            // txtAccountType
            // 
            this.txtAccountType.AutoSize = true;
            this.txtAccountType.Location = new System.Drawing.Point(669, 35);
            this.txtAccountType.Name = "txtAccountType";
            this.txtAccountType.Size = new System.Drawing.Size(35, 13);
            this.txtAccountType.TabIndex = 6;
            this.txtAccountType.Text = "label1";
            this.txtAccountType.Visible = false;
            // 
            // ribbonPageGroup14
            // 
            this.ribbonPageGroup14.ItemLinks.Add(this.btnPC);
            this.ribbonPageGroup14.Name = "ribbonPageGroup14";
            // 
            // btnPC
            // 
            this.btnPC.Caption = "Phân công chuyên đề";
            this.btnPC.Id = 17;
            this.btnPC.Name = "btnPC";
            this.btnPC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPC_ItemClick);
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 449);
            this.Controls.Add(this.txtAccountType);
            this.Controls.Add(this.txtAccountCode);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmIndex";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Màn hình chính";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmIndex_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.BarButtonItem btnCreateMajors;
        private DevExpress.XtraBars.BarButtonItem btnEditMajoirs;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnCreateSubjects;
        private DevExpress.XtraBars.BarButtonItem btnEditSubjects;
        private DevExpress.XtraBars.BarButtonItem CreateThematic;
        private DevExpress.XtraBars.BarButtonItem EditThematic;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem CreateGroup;
        private DevExpress.XtraBars.BarButtonItem EditGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.BarButtonItem OK;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem btnOpenThematic;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.BarButtonItem btnEditOpenThematic;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.BarButtonItem btnJoinGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private System.Windows.Forms.Label txtAccountCode;
        private System.Windows.Forms.Label txtAccountType;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.BarButtonItem btnCreateAccount;
        private DevExpress.XtraBars.BarButtonItem btnEditAccount;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup13;
        private DevExpress.XtraBars.BarButtonItem btnPC;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup14;
    }
}