using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomCalc
{

    public partial class FormMain : Form
    {
        Double TotalFloorArea;
        Double TotalWallArea;
        Double TotalRoomVolume;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //Initialise combo box and hide sections not needed for rectangle entry
            CmbSectType.SelectedIndex = 0;
            LblHyp.Visible = false;
            TxtHyp.Visible = false;
        }

        private void CmbSectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CmbSectType.SelectedIndex)
            {
                case 0: //load needed sections for rectangle entry
                    LblHyp.Visible = false;
                    TxtHyp.Visible = false;
                    ChkWall1.Enabled = true;
                    ChkWall2.Visible = true;
                    ChkWall3.Visible = false;
                    ChkRec1.Visible = true;
                    ChkRec2.Visible = true;
                    LblInput3.Visible = true;
                    TxtInput3.Visible = true;
                    LblSectType.Text = "This allows you to add a normal rectangular section";
                    LblInput2.Text = "Width";
                    ResetInput();
                    break;
                case 1: //load needed sections for triangle entry
                    LblHyp.Visible = true;
                    TxtHyp.Visible = true;
                    ChkWall1.Enabled = true;
                    ChkWall2.Visible = true;
                    ChkWall3.Visible = true;
                    ChkRec1.Visible = false;
                    ChkRec2.Visible = false;
                    LblInput3.Visible = true;
                    TxtInput3.Visible = true;
                    LblSectType.Text = "This allows you to add a triangular section";
                    LblInput2.Text = "Width";
                    ResetInput();
                    break;
                case 2: //load needed sections for semi-circle entry
                    LblHyp.Visible = false;
                    TxtHyp.Visible = false;
                    ChkWall1.Checked = true;
                    ChkWall1.Enabled = false;
                    ChkWall2.Visible = false;
                    ChkWall3.Visible = false;
                    ChkRec1.Visible = false;
                    ChkRec2.Visible = false;
                    LblInput3.Visible = false;
                    TxtInput3.Visible = false;
                    LblSectType.Text = "This allows you to add a half circular section";
                    LblInput2.Text = "Radius";
                    ResetInput();
                    TxtInput3.Text = "0";
                    break;

            }

        }

        private void BtnAddSect_Click(object sender, EventArgs e)
        {
            Double Height;
            Double Width;
            Double Length;
            Double Hyp;

            //Check input for empty fields
            if (TxtInput1.Text == "" || TxtInput2.Text == "" || TxtInput3.Text == "")
            {
                MessageBox.Show("Necessary fields empty", "Alert");
                return;
            }
            //Check if fields are numbers
            else if (IsNumber(TxtInput1.Text) == false || IsNumber(TxtInput2.Text) == false || IsNumber(TxtInput3.Text) == false)
            {
                MessageBox.Show("Fields cannot contain characters", "Alert");
                return;
            }
            //read fields
            if (CmbSectType.SelectedIndex != 2)
            {
                Height = Convert.ToDouble(TxtInput1.Text);
                Width = Convert.ToDouble(TxtInput2.Text);
                Length = Convert.ToDouble(TxtInput3.Text);
            }
            else
            {
                Height = Convert.ToDouble(TxtInput1.Text);
                Width = Convert.ToDouble(TxtInput2.Text);
                Length = 0;
            }
            switch (CmbSectType.SelectedIndex)
            {

                case 0:

                    TotalFloorArea += (Width * Length);
                    TotalRoomVolume += (Width * Height * Length);

                    if (ChkRec1.Checked && ChkRec2.Checked && ChkWall1.Checked && ChkWall2.Checked)
                    {
                        //All walls checked
                        TotalWallArea += (2*(Height*Width) + 2*(Height*Length));
                        LstSect.Items.Add("Rectangle with 4 walls, Height = " + Height.ToString() + "m Width = " + Width.ToString() + "m Length = " + Length.ToString() + "m");
                        UpdateTotals();
                    }
                    else if ((!ChkRec1.Checked && ChkRec2.Checked && ChkWall1.Checked && ChkWall2.Checked) || (ChkRec1.Checked && ChkRec2.Checked && !ChkWall1.Checked && ChkWall2.Checked))
                    {
                        //Missing 1 width
                        TotalWallArea += ((Height * Width) + 2 * (Height * Length));
                        LstSect.Items.Add("Rectangle with 3 walls missing a width, Height = " + Height.ToString() + "m Width = " + Width.ToString() + "m Length = " + Length.ToString() + "m");
                        UpdateTotals();
                    }
                    else if ((ChkRec1.Checked && !ChkRec2.Checked && ChkWall1.Checked && ChkWall2.Checked) || (ChkRec1.Checked && ChkRec2.Checked && ChkWall1.Checked && !ChkWall2.Checked))
                    {
                        //Missing 1 length
                        TotalWallArea += (2 * (Height * Width) + (Height * Length));
                        LstSect.Items.Add("Rectangle with 3 walls missing a length, Height = " + Height.ToString() + "m Width = " + Width.ToString() + "m Length = " + Length.ToString() + "m");
                        UpdateTotals();
                    }
                    else if ((!ChkRec1.Checked && !ChkRec2.Checked && ChkWall1.Checked && ChkWall2.Checked) || (ChkRec1.Checked && ChkRec2.Checked && !ChkWall1.Checked && !ChkWall2.Checked) || (!ChkRec1.Checked && ChkRec2.Checked && ChkWall1.Checked && !ChkWall2.Checked) || (ChkRec1.Checked && !ChkRec2.Checked && !ChkWall1.Checked && ChkWall2.Checked))
                    {
                        //One width and one length checked
                        TotalWallArea += ((Height * Width) + (Height * Length));
                        LstSect.Items.Add("90 degree corner, Height = " + Height.ToString() + "m Width = " + Width.ToString() + "m Length = " + Length.ToString() + "m");
                        UpdateTotals();
                    }
                    else if (ChkRec1.Checked && !ChkRec2.Checked && ChkWall1.Checked && !ChkWall2.Checked )
                    {
                        //Corridor using width (both width selected)
                        TotalWallArea += (2 *(Height * Width));
                        LstSect.Items.Add("Corridor using width entry, Height = " + Height.ToString() + "m Width = " + Width.ToString() + "m Length = " + Length.ToString() + "m");
                        UpdateTotals();
                    }
                    else if (!ChkRec1.Checked && ChkRec2.Checked && !ChkWall1.Checked && ChkWall2.Checked)
                    {
                        //Corridor using length (both length selected)
                        TotalWallArea += (2 *(Height * Length));
                        LstSect.Items.Add("Corridor using length entry, Height = " + Height.ToString() + "m Width = " + Width.ToString() + "m Length = " + Length.ToString() + "m");
                        UpdateTotals();
                    }
                    else
                    {
                        TotalFloorArea -= (Width * Length);
                        TotalRoomVolume -= (Width * Height * Length);
                        MessageBox.Show("Rectangle must have at least 2 walls", "Alert");
                        return;
                    }
                    break;
                case 1:

                    if (IsNumber(TxtHyp.Text) == false || TxtHyp.Text == "")
                    {
                        MessageBox.Show("Fields cannot contain characters, or be empty","Alert");
                        return;
                    }
                    else
                    {
                        Hyp = Convert.ToDouble(TxtHyp.Text);
                    }
                    if ((Width + Length) <= Hyp)
                    {
                        MessageBox.Show("Please ensure (Width + Length) > Hypotenuse", "Alert");
                        return;
                    }

                    TotalFloorArea += (TriPrismBase(Width, Length, Hyp) / 4);
                    TotalRoomVolume += (TriPrismBase(Width, Length, Hyp) * (Height / 4));

                    if (ChkWall1.Checked && ChkWall2.Checked && ChkWall3.Checked)
                    {
                        //All walls checked
                        TotalWallArea += ((Height * Width) + (Height * Length) + (Height * Hyp));
                        LstSect.Items.Add("Triangle with 3 walls, Height = " + Height.ToString() + "m Width = " + Width.ToString() + "m Length = " + Length.ToString() + "m Hypotenuse = " + Hyp.ToString() + "m");
                        UpdateTotals();
                    }
                    else if (ChkWall1.Checked && ChkWall2.Checked && !ChkWall3.Checked)
                    {
                        //All but hyp checked
                        TotalWallArea += ((Height * Width) + (Height * Length));
                        LstSect.Items.Add("Triangle with 2 walls, missing hypotenuse, Height = " + Height.ToString() + "m Width = " + Width.ToString() + "m Length = " + Length.ToString() + "m Hypotenuse = " + Hyp.ToString() + "m");
                        UpdateTotals();
                    }
                    else if (ChkWall1.Checked && !ChkWall2.Checked && ChkWall3.Checked)
                    {
                        //All but length checked
                        TotalWallArea += ((Height * Width) + (Height * Hyp));
                        LstSect.Items.Add("Triangle with 2 walls, missing length, Height = " + Height.ToString() + "m Width = " + Width.ToString() + "m Length = " + Length.ToString() + "m Hypotenuse = " + Hyp.ToString() + "m");
                        UpdateTotals();
                    }
                    else if (!ChkWall1.Checked && ChkWall2.Checked && ChkWall3.Checked)
                    {
                        //All but width checked
                        TotalWallArea += ((Height * Length) + (Height * Hyp));
                        LstSect.Items.Add("Triangle with 2 walls, missing width, Height = " + Height.ToString() + "m Width = " + Width.ToString() + "m Length = " + Length.ToString() + "m Hypotenuse = " + Hyp.ToString() + "m");
                        UpdateTotals();
                    }
                    else if (ChkWall1.Checked && !ChkWall2.Checked && !ChkWall3.Checked)
                    {
                        //Just width checked
                        TotalWallArea += (Height * Width);
                        LstSect.Items.Add("Triangle with 1 wall, just width, Height = " + Height.ToString() + "m Width = " + Width.ToString() + "m Length = " + Length.ToString() + "m Hypotenuse = " + Hyp.ToString() + "m");
                        UpdateTotals();
                    }
                    else if (!ChkWall1.Checked && ChkWall2.Checked && !ChkWall3.Checked)
                    {
                        //Just length checked
                        TotalWallArea += (Height * Length);
                        LstSect.Items.Add("Triangle with 1 wall, just length, Height = " + Height.ToString() + "m Width = " + Width.ToString() + "m Length = " + Length.ToString() + "m Hypotenuse = " + Hyp.ToString() + "m");
                        UpdateTotals();
                    }
                    else if (!ChkWall1.Checked && !ChkWall2.Checked && ChkWall3.Checked)
                    {
                        //Just hyp checked
                        TotalWallArea += (Height * Hyp);
                        LstSect.Items.Add("Triangle with 1 wall, just hypotenuse, Height = " + Height.ToString() + "m Width = " + Width.ToString() + "m Length = " + Length.ToString() + "m Hypotenuse = " + Hyp.ToString() + "m");
                        UpdateTotals();
                    }
                    else
                    {
                        TotalFloorArea -= (TriPrismBase(Width, Length, Hyp) / 4);
                        TotalRoomVolume -= (TriPrismBase(Width, Length, Hyp) * (Height / 4));
                        MessageBox.Show("Please check at least 1 wall", "Alert");
                        return;
                    }
                    break;
                case 2:
                    TotalFloorArea += ((Math.PI * (Math.Pow(Width,2))) / 2);
                    TotalRoomVolume += Height * ((Math.PI * (Math.Pow(Width,2))) / 2);
                    TotalWallArea += (Math.PI * Width * Height);
                    LstSect.Items.Add("Semi-Circle with Height = " + Height.ToString() + "m Radius = " + Width.ToString() + "m");
                    UpdateTotals();
                    break;
            }
        }
        public void ResetInput()
        {
            TxtInput1.Text = "";
            TxtInput2.Text = "";
            TxtInput3.Text = "";
            TxtHyp.Text = "";
        }
        private void UpdateTotals()
        {
            LblArea.Text = ("Floor area: " + TotalFloorArea.ToString() + "m²");
            LblVol.Text = ("Room volume: " + TotalRoomVolume.ToString() + "m³");
            LblPaintReq.Text = ("Paint required for walls: " + TotalWallArea.ToString() + "m²");
        }
        public Boolean IsNumber(String s)
        {
            return s.All(Char.IsDigit);
        }
        public Double TriPrismBase(Double a, Double b, Double c)
        {
            // SqRoot((-a^4)+(2(ab)^2)+(2(ac)^2)-(b^4)+(2(bc)^2)-(c^4))
                return Math.Sqrt((0 - Math.Pow(a, 4)) + (2 * Math.Pow((a * b), 2)) + (2 * Math.Pow((a * c), 2)) - (Math.Pow(b, 4)) + (2 * Math.Pow((b * c), 2)) - (Math.Pow(c, 4)));
        }

    }
}
