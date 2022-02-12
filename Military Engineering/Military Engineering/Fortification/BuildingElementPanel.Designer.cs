namespace MilitaryEngineering.Fortification
{
    partial class BuildingElementPanel
    {
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        public System.Windows.Forms.Label SecondTurnLabel;
        public System.Windows.Forms.Label FutureTurnLabel;
        public System.Windows.Forms.Label ElementNameLabel;
        public System.Windows.Forms.Label FirstTurnLabel;
        public System.Windows.Forms.Label AllTurnsLabel;
        private System.Windows.Forms.ComboBox SoilTypeBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;

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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.SoilTypeBox = new System.Windows.Forms.ComboBox();
            this.SoilTypeLabel = new System.Windows.Forms.Label();
            this.PollutionsBox = new System.Windows.Forms.ComboBox();
            this.PollutionLabel = new System.Windows.Forms.Label();
            this.DayTimeLabel = new System.Windows.Forms.Label();
            this.DayTimeBox = new System.Windows.Forms.ComboBox();
            this.CheckBox = new MilitaryEngineering.Controls.CheckBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.WorkTimeInput = new System.Windows.Forms.TextBox();
            this.ManPowerInput = new System.Windows.Forms.TextBox();
            this.AttritionRateInput = new System.Windows.Forms.TextBox();
            this.OrganizationInput = new System.Windows.Forms.TextBox();
            this.CoeffThoursLabel = new System.Windows.Forms.Label();
            this.PeopleAmountInput = new System.Windows.Forms.TextBox();
            this.CoeffKorganizationLabel = new System.Windows.Forms.Label();
            this.CoeffKcallingLabel = new System.Windows.Forms.Label();
            this.CoeffKstaffingLabel = new System.Windows.Forms.Label();
            this.CoeffNpersonnelLabel = new System.Windows.Forms.Label();
            this.AddGainButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SecondTurnLabel = new System.Windows.Forms.Label();
            this.FutureTurnLabel = new System.Windows.Forms.Label();
            this.ElementNameLabel = new System.Windows.Forms.Label();
            this.FirstTurnLabel = new System.Windows.Forms.Label();
            this.AllTurnsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.AllTurnEvaluationLabel = new System.Windows.Forms.Label();
            this.FutureTurnEvaluationLabel = new System.Windows.Forms.Label();
            this.SecondTurnEvaluationLabel = new System.Windows.Forms.Label();
            this.FirstTurnEvaluationLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.CoeffInfoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 150);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.72549F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.27451F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 47);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(484, 101);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.05882F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.94118F));
            this.tableLayoutPanel4.Controls.Add(this.SoilTypeBox, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.SoilTypeLabel, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.PollutionsBox, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.PollutionLabel, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.DayTimeLabel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.DayTimeBox, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.CheckBox, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(183, 97);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // SoilTypeBox
            // 
            this.SoilTypeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.SoilTypeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SoilTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SoilTypeBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SoilTypeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.SoilTypeBox.FormattingEnabled = true;
            this.SoilTypeBox.Location = new System.Drawing.Point(103, 66);
            this.SoilTypeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SoilTypeBox.Name = "SoilTypeBox";
            this.SoilTypeBox.Size = new System.Drawing.Size(78, 25);
            this.SoilTypeBox.TabIndex = 4;
            this.SoilTypeBox.SelectedIndexChanged += new System.EventHandler(this.SoilTypeBox_SelectedIndexChanged);
            // 
            // SoilTypeLabel
            // 
            this.SoilTypeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SoilTypeLabel.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SoilTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.SoilTypeLabel.Location = new System.Drawing.Point(32, 64);
            this.SoilTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SoilTypeLabel.Name = "SoilTypeLabel";
            this.SoilTypeLabel.Size = new System.Drawing.Size(67, 33);
            this.SoilTypeLabel.TabIndex = 12;
            this.SoilTypeLabel.Text = "Тип грунта";
            this.SoilTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PollutionsBox
            // 
            this.PollutionsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.PollutionsBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PollutionsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PollutionsBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PollutionsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.PollutionsBox.FormattingEnabled = true;
            this.PollutionsBox.Location = new System.Drawing.Point(103, 34);
            this.PollutionsBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PollutionsBox.Name = "PollutionsBox";
            this.PollutionsBox.Size = new System.Drawing.Size(78, 25);
            this.PollutionsBox.TabIndex = 3;
            this.PollutionsBox.SelectedIndexChanged += new System.EventHandler(this.PollutionsBox_SelectedIndexChanged);
            // 
            // PollutionLabel
            // 
            this.PollutionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PollutionLabel.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PollutionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.PollutionLabel.Location = new System.Drawing.Point(32, 32);
            this.PollutionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PollutionLabel.Name = "PollutionLabel";
            this.PollutionLabel.Size = new System.Drawing.Size(67, 32);
            this.PollutionLabel.TabIndex = 9;
            this.PollutionLabel.Text = "Заражение";
            this.PollutionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DayTimeLabel
            // 
            this.DayTimeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DayTimeLabel.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.DayTimeLabel.Location = new System.Drawing.Point(32, 0);
            this.DayTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DayTimeLabel.Name = "DayTimeLabel";
            this.DayTimeLabel.Size = new System.Drawing.Size(67, 32);
            this.DayTimeLabel.TabIndex = 6;
            this.DayTimeLabel.Text = "Время суток";
            this.DayTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DayTimeBox
            // 
            this.DayTimeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.DayTimeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DayTimeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DayTimeBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DayTimeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.DayTimeBox.FormattingEnabled = true;
            this.DayTimeBox.Location = new System.Drawing.Point(103, 2);
            this.DayTimeBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DayTimeBox.Name = "DayTimeBox";
            this.DayTimeBox.Size = new System.Drawing.Size(78, 25);
            this.DayTimeBox.TabIndex = 2;
            this.DayTimeBox.SelectedIndexChanged += new System.EventHandler(this.DayTimeBox_SelectedIndexChanged);
            // 
            // CheckBox
            // 
            this.CheckBox.BackgroundImage = global::MilitaryEngineering.Properties.Resources.CheckBoxUnchecked;
            this.CheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CheckBox.Checked = false;
            this.CheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBox.ImgChecked = global::MilitaryEngineering.Properties.Resources.CheckBoxChecked;
            this.CheckBox.ImgCheckedHower = global::MilitaryEngineering.Properties.Resources.CheckBoxCheckedHover;
            this.CheckBox.ImgDefault = global::MilitaryEngineering.Properties.Resources.CheckBoxUnchecked;
            this.CheckBox.ImgDefaultHower = global::MilitaryEngineering.Properties.Resources.CheckBoxUncheckedHover;
            this.CheckBox.Location = new System.Drawing.Point(2, 34);
            this.CheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(26, 28);
            this.CheckBox.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(189, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(293, 97);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel6.Controls.Add(this.WorkTimeInput, 3, 1);
            this.tableLayoutPanel6.Controls.Add(this.ManPowerInput, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.AttritionRateInput, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.OrganizationInput, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.CoeffThoursLabel, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.PeopleAmountInput, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.CoeffKorganizationLabel, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.CoeffKcallingLabel, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.CoeffKstaffingLabel, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.CoeffNpersonnelLabel, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.AddGainButton, 3, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(289, 93);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.label7.Location = new System.Drawing.Point(146, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 31);
            this.label7.TabIndex = 25;
            this.label7.Text = "Усиление";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorkTimeInput
            // 
            this.WorkTimeInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.WorkTimeInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkTimeInput.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorkTimeInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.WorkTimeInput.Location = new System.Drawing.Point(218, 33);
            this.WorkTimeInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.WorkTimeInput.Name = "WorkTimeInput";
            this.WorkTimeInput.Size = new System.Drawing.Size(69, 24);
            this.WorkTimeInput.TabIndex = 9;
            this.WorkTimeInput.TextChanged += new System.EventHandler(this.WorkTimeInput_TextChanged);
            // 
            // ManPowerInput
            // 
            this.ManPowerInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.ManPowerInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManPowerInput.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ManPowerInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ManPowerInput.Location = new System.Drawing.Point(74, 33);
            this.ManPowerInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManPowerInput.Name = "ManPowerInput";
            this.ManPowerInput.Size = new System.Drawing.Size(68, 24);
            this.ManPowerInput.TabIndex = 6;
            this.ManPowerInput.TextChanged += new System.EventHandler(this.ManPowerInput_TextChanged);
            // 
            // AttritionRateInput
            // 
            this.AttritionRateInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.AttritionRateInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AttritionRateInput.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AttritionRateInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.AttritionRateInput.Location = new System.Drawing.Point(218, 2);
            this.AttritionRateInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AttritionRateInput.Name = "AttritionRateInput";
            this.AttritionRateInput.Size = new System.Drawing.Size(69, 24);
            this.AttritionRateInput.TabIndex = 8;
            this.AttritionRateInput.TextChanged += new System.EventHandler(this.AttritionRateInput_TextChanged);
            // 
            // OrganizationInput
            // 
            this.OrganizationInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.OrganizationInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrganizationInput.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrganizationInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.OrganizationInput.Location = new System.Drawing.Point(74, 64);
            this.OrganizationInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.OrganizationInput.Name = "OrganizationInput";
            this.OrganizationInput.Size = new System.Drawing.Size(68, 24);
            this.OrganizationInput.TabIndex = 7;
            this.OrganizationInput.TextChanged += new System.EventHandler(this.OrganizationInput_TextChanged);
            // 
            // CoeffThoursLabel
            // 
            this.CoeffThoursLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoeffThoursLabel.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoeffThoursLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.CoeffThoursLabel.Location = new System.Drawing.Point(146, 31);
            this.CoeffThoursLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CoeffThoursLabel.Name = "CoeffThoursLabel";
            this.CoeffThoursLabel.Size = new System.Drawing.Size(68, 31);
            this.CoeffThoursLabel.TabIndex = 20;
            this.CoeffThoursLabel.Text = "tч";
            this.CoeffThoursLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PeopleAmountInput
            // 
            this.PeopleAmountInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.PeopleAmountInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PeopleAmountInput.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PeopleAmountInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.PeopleAmountInput.Location = new System.Drawing.Point(74, 2);
            this.PeopleAmountInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PeopleAmountInput.Name = "PeopleAmountInput";
            this.PeopleAmountInput.Size = new System.Drawing.Size(68, 24);
            this.PeopleAmountInput.TabIndex = 5;
            this.PeopleAmountInput.TextChanged += new System.EventHandler(this.PeopleAmountInput_TextChanged);
            // 
            // CoeffKorganizationLabel
            // 
            this.CoeffKorganizationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoeffKorganizationLabel.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoeffKorganizationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.CoeffKorganizationLabel.Location = new System.Drawing.Point(2, 62);
            this.CoeffKorganizationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CoeffKorganizationLabel.Name = "CoeffKorganizationLabel";
            this.CoeffKorganizationLabel.Size = new System.Drawing.Size(68, 31);
            this.CoeffKorganizationLabel.TabIndex = 17;
            this.CoeffKorganizationLabel.Text = "Kор";
            this.CoeffKorganizationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CoeffKcallingLabel
            // 
            this.CoeffKcallingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoeffKcallingLabel.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoeffKcallingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.CoeffKcallingLabel.Location = new System.Drawing.Point(146, 0);
            this.CoeffKcallingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CoeffKcallingLabel.Name = "CoeffKcallingLabel";
            this.CoeffKcallingLabel.Size = new System.Drawing.Size(68, 31);
            this.CoeffKcallingLabel.TabIndex = 16;
            this.CoeffKcallingLabel.Text = "Kпр";
            this.CoeffKcallingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CoeffKstaffingLabel
            // 
            this.CoeffKstaffingLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoeffKstaffingLabel.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoeffKstaffingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.CoeffKstaffingLabel.Location = new System.Drawing.Point(2, 31);
            this.CoeffKstaffingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CoeffKstaffingLabel.Name = "CoeffKstaffingLabel";
            this.CoeffKstaffingLabel.Size = new System.Drawing.Size(68, 31);
            this.CoeffKstaffingLabel.TabIndex = 15;
            this.CoeffKstaffingLabel.Text = "Kук";
            this.CoeffKstaffingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CoeffNpersonnelLabel
            // 
            this.CoeffNpersonnelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CoeffNpersonnelLabel.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CoeffNpersonnelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.CoeffNpersonnelLabel.Location = new System.Drawing.Point(2, 0);
            this.CoeffNpersonnelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CoeffNpersonnelLabel.Name = "CoeffNpersonnelLabel";
            this.CoeffNpersonnelLabel.Size = new System.Drawing.Size(68, 31);
            this.CoeffNpersonnelLabel.TabIndex = 14;
            this.CoeffNpersonnelLabel.Text = "Nлс";
            this.CoeffNpersonnelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddGainButton
            // 
            this.AddGainButton.AutoSize = true;
            this.AddGainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.AddGainButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddGainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddGainButton.Font = new System.Drawing.Font("Bahnschrift", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddGainButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.AddGainButton.Location = new System.Drawing.Point(218, 64);
            this.AddGainButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddGainButton.Name = "AddGainButton";
            this.AddGainButton.Size = new System.Drawing.Size(69, 27);
            this.AddGainButton.TabIndex = 10;
            this.AddGainButton.TabStop = false;
            this.AddGainButton.Text = "Добавить\r\nэлемент";
            this.AddGainButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddGainButton.UseVisualStyleBackColor = false;
            this.AddGainButton.Click += new System.EventHandler(this.AddGainButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.Controls.Add(this.SecondTurnLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.FutureTurnLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ElementNameLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.FirstTurnLabel, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.AllTurnsLabel, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(484, 41);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // SecondTurnLabel
            // 
            this.SecondTurnLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondTurnLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.SecondTurnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.SecondTurnLabel.Location = new System.Drawing.Point(267, 0);
            this.SecondTurnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SecondTurnLabel.Name = "SecondTurnLabel";
            this.SecondTurnLabel.Size = new System.Drawing.Size(68, 41);
            this.SecondTurnLabel.TabIndex = 7;
            this.SecondTurnLabel.Text = "SecondTurn";
            this.SecondTurnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FutureTurnLabel
            // 
            this.FutureTurnLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FutureTurnLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.FutureTurnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.FutureTurnLabel.Location = new System.Drawing.Point(339, 0);
            this.FutureTurnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FutureTurnLabel.Name = "FutureTurnLabel";
            this.FutureTurnLabel.Size = new System.Drawing.Size(68, 41);
            this.FutureTurnLabel.TabIndex = 6;
            this.FutureTurnLabel.Text = "FutureTurnLabel";
            this.FutureTurnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ElementNameLabel
            // 
            this.ElementNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ElementNameLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.ElementNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.ElementNameLabel.Location = new System.Drawing.Point(2, 0);
            this.ElementNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ElementNameLabel.Name = "ElementNameLabel";
            this.ElementNameLabel.Size = new System.Drawing.Size(189, 41);
            this.ElementNameLabel.TabIndex = 5;
            this.ElementNameLabel.Text = "Name";
            this.ElementNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FirstTurnLabel
            // 
            this.FirstTurnLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstTurnLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.FirstTurnLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.FirstTurnLabel.Location = new System.Drawing.Point(195, 0);
            this.FirstTurnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstTurnLabel.Name = "FirstTurnLabel";
            this.FirstTurnLabel.Size = new System.Drawing.Size(68, 41);
            this.FirstTurnLabel.TabIndex = 4;
            this.FirstTurnLabel.Text = "FirstTurnLabel";
            this.FirstTurnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AllTurnsLabel
            // 
            this.AllTurnsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllTurnsLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.AllTurnsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.AllTurnsLabel.Location = new System.Drawing.Point(411, 0);
            this.AllTurnsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AllTurnsLabel.Name = "AllTurnsLabel";
            this.AllTurnsLabel.Size = new System.Drawing.Size(71, 41);
            this.AllTurnsLabel.TabIndex = 8;
            this.AllTurnsLabel.Text = "AllTurnsLabel";
            this.AllTurnsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.5F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.5F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.chart1, 2, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1083, 154);
            this.tableLayoutPanel7.TabIndex = 7;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel8.Controls.Add(this.AllTurnEvaluationLabel, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.FutureTurnEvaluationLabel, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.SecondTurnEvaluationLabel, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.FirstTurnEvaluationLabel, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(494, 2);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(261, 150);
            this.tableLayoutPanel8.TabIndex = 1;
            // 
            // AllTurnEvaluationLabel
            // 
            this.AllTurnEvaluationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AllTurnEvaluationLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.AllTurnEvaluationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.AllTurnEvaluationLabel.Location = new System.Drawing.Point(197, 0);
            this.AllTurnEvaluationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AllTurnEvaluationLabel.Name = "AllTurnEvaluationLabel";
            this.AllTurnEvaluationLabel.Size = new System.Drawing.Size(62, 150);
            this.AllTurnEvaluationLabel.TabIndex = 9;
            this.AllTurnEvaluationLabel.Text = "Ошибка";
            this.AllTurnEvaluationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FutureTurnEvaluationLabel
            // 
            this.FutureTurnEvaluationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FutureTurnEvaluationLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.FutureTurnEvaluationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.FutureTurnEvaluationLabel.Location = new System.Drawing.Point(132, 0);
            this.FutureTurnEvaluationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FutureTurnEvaluationLabel.Name = "FutureTurnEvaluationLabel";
            this.FutureTurnEvaluationLabel.Size = new System.Drawing.Size(61, 150);
            this.FutureTurnEvaluationLabel.TabIndex = 8;
            this.FutureTurnEvaluationLabel.Text = "Ошибка";
            this.FutureTurnEvaluationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SecondTurnEvaluationLabel
            // 
            this.SecondTurnEvaluationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondTurnEvaluationLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.SecondTurnEvaluationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.SecondTurnEvaluationLabel.Location = new System.Drawing.Point(67, 0);
            this.SecondTurnEvaluationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SecondTurnEvaluationLabel.Name = "SecondTurnEvaluationLabel";
            this.SecondTurnEvaluationLabel.Size = new System.Drawing.Size(61, 150);
            this.SecondTurnEvaluationLabel.TabIndex = 7;
            this.SecondTurnEvaluationLabel.Text = "Ошибка";
            this.SecondTurnEvaluationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FirstTurnEvaluationLabel
            // 
            this.FirstTurnEvaluationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstTurnEvaluationLabel.Font = new System.Drawing.Font("Bahnschrift", 15F);
            this.FirstTurnEvaluationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.FirstTurnEvaluationLabel.Location = new System.Drawing.Point(2, 0);
            this.FirstTurnEvaluationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstTurnEvaluationLabel.Name = "FirstTurnEvaluationLabel";
            this.FirstTurnEvaluationLabel.Size = new System.Drawing.Size(61, 150);
            this.FirstTurnEvaluationLabel.TabIndex = 6;
            this.FirstTurnEvaluationLabel.Text = "Ошибка";
            this.FirstTurnEvaluationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(52)))), ((int)(((byte)(81)))));
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(180)))), ((int)(((byte)(199)))));
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(759, 2);
            this.chart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series5.LabelForeColor = System.Drawing.Color.White;
            series5.Name = "Сроки занятия";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series6.Name = "Первая Очередь";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series7.Name = "Вторая очередь";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series8.Name = "В будущем";
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(322, 150);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // CoeffInfoToolTip
            // 
            this.CoeffInfoToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.CoeffInfoToolTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            // 
            // BuildingElementPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.tableLayoutPanel7);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BuildingElementPanel";
            this.Size = new System.Drawing.Size(1085, 167);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        public System.Windows.Forms.Label SoilTypeLabel;
        private System.Windows.Forms.ComboBox PollutionsBox;
        public System.Windows.Forms.Label PollutionLabel;
        public System.Windows.Forms.Label DayTimeLabel;
        private System.Windows.Forms.ComboBox DayTimeBox;
        public Controls.CheckBox CheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        public System.Windows.Forms.Label CoeffKorganizationLabel;
        public System.Windows.Forms.Label CoeffKcallingLabel;
        public System.Windows.Forms.Label CoeffKstaffingLabel;
        public System.Windows.Forms.Label CoeffNpersonnelLabel;
        private System.Windows.Forms.TextBox WorkTimeInput;
        private System.Windows.Forms.TextBox ManPowerInput;
        private System.Windows.Forms.TextBox AttritionRateInput;
        private System.Windows.Forms.TextBox OrganizationInput;
        public System.Windows.Forms.Label CoeffThoursLabel;
        private System.Windows.Forms.TextBox PeopleAmountInput;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        public System.Windows.Forms.Label AllTurnEvaluationLabel;
        public System.Windows.Forms.Label FutureTurnEvaluationLabel;
        public System.Windows.Forms.Label SecondTurnEvaluationLabel;
        public System.Windows.Forms.Label FirstTurnEvaluationLabel;
        private System.Windows.Forms.ToolTip CoeffInfoToolTip;
        private System.Windows.Forms.Button AddGainButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}