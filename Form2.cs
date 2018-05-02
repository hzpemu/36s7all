using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading; 
using System.IO;

namespace Application1
{
	/// <summary>
	/// Form2 的摘要说明。
	/// </summary>
	public class Form2 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.Button button1;
		private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
		private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
		private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
		private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
		private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
		private System.Data.OleDb.OleDbConnection oleDbConnection1;
		private System.Data.OleDb.OleDbCommand oleDbCommand1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button button2;
		private Thread oThread;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private int s1,s2,s3,s4,s5,s6,s7,lll3,ttt1,ttt2,ttt3,oncheck1,oncheck2,oncheck3,oncheck4,oncheck5,oncheck6,oncheck7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public Form2()
		{
			//
			// Windows 窗体设计器支持所必需的
			//
			InitializeComponent();
			this.oThread= new Thread(new ThreadStart(this.nb));

			//
			// TODO: 在 InitializeComponent 调用后添加任何构造函数代码
			//
		}

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows 窗体设计器生成的代码
		/// <summary>
		/// 设计器支持所需的方法 - 不要使用代码编辑器修改
		/// 此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.button1 = new System.Windows.Forms.Button();
			this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
			this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
			this.oleDbConnection1 = new System.Data.OleDb.OleDbConnection();
			this.oleDbCommand1 = new System.Data.OleDb.OleDbCommand();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(24, 80);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(112, 40);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "去除6个连续";
			this.checkBox1.Visible = false;
			// 
			// checkBox2
			// 
			this.checkBox2.Location = new System.Drawing.Point(24, 120);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(112, 48);
			this.checkBox2.TabIndex = 1;
			this.checkBox2.Text = "去除5个连续";
			this.checkBox2.Visible = false;
			// 
			// checkBox3
			// 
			this.checkBox3.Location = new System.Drawing.Point(24, 168);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(112, 40);
			this.checkBox3.TabIndex = 2;
			this.checkBox3.Text = "去除4个连续";
			this.checkBox3.Visible = false;
			// 
			// checkBox4
			// 
			this.checkBox4.Location = new System.Drawing.Point(168, 48);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(112, 40);
			this.checkBox4.TabIndex = 3;
			this.checkBox4.Text = "去除3个连续";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(168, 104);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 32);
			this.button1.TabIndex = 4;
			this.button1.Text = "生成表";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// oleDbDataAdapter1
			// 
			this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
			this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
			this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
			this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
			// 
			// oleDbCommand1
			// 
			this.oleDbCommand1.Connection = this.oleDbConnection1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(64, 216);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(400, 40);
			this.label1.TabIndex = 5;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(424, 24);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(24, 21);
			this.textBox1.TabIndex = 6;
			this.textBox1.Text = "";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(264, 28);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(160, 16);
			this.label2.TabIndex = 7;
			this.label2.Text = "去除十位上出现的相同个数";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(424, 48);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(24, 21);
			this.textBox2.TabIndex = 8;
			this.textBox2.Text = "";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(264, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(160, 24);
			this.label3.TabIndex = 9;
			this.label3.Text = "去除个位上相同的个数";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(264, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(160, 24);
			this.label4.TabIndex = 10;
			this.label4.Text = "去除个位上连续的个数";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(424, 72);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(24, 21);
			this.textBox3.TabIndex = 11;
			this.textBox3.Text = "";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(168, 136);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(104, 32);
			this.button2.TabIndex = 12;
			this.button2.Text = "暂停";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(168, 168);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(104, 32);
			this.button3.TabIndex = 13;
			this.button3.Text = "继续";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(280, 104);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(80, 48);
			this.button4.TabIndex = 14;
			this.button4.Text = "运行状态";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(280, 152);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(80, 48);
			this.button5.TabIndex = 15;
			this.button5.Text = "终止生成";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(360, 104);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(88, 48);
			this.button6.TabIndex = 16;
			this.button6.Text = "读取上次被终止的进程状态(1)";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(360, 152);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(88, 48);
			this.button7.TabIndex = 17;
			this.button7.Text = "继续上次被终止的进程(2)";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// Form2
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(6, 14);
			this.ClientSize = new System.Drawing.Size(520, 273);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.checkBox4);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			this.ResumeLayout(false);

		}
		#endregion


		void nb()
		{
			int c6=0,c5=0,c4=0,c3=0;
			if(this.checkBox1.CheckState.ToString()=="Checked"){c6=1;}
			if(this.checkBox2.CheckState.ToString()=="Checked"){c5=1;}
			if(this.checkBox3.CheckState.ToString()=="Checked"){c4=1;}
			if(this.checkBox4.CheckState.ToString()=="Checked"){c3=1;this.lll3=1;}
			else{lll3=0;}
			
			
			this.oleDbConnection1.ConnectionString=@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source="+Application.StartupPath+"\\data.mdb;";
			this.oleDbConnection1.Open();
			//            this.oleDbCommand1.CommandText="INSERT INTO table1 (no1,no2,no3,no4,no5,no6,no7,s,date1) VALUES('2','3','4','5','6','7','8','1','akjd')";
			
			for(int n1=1;n1<=36;)
			{
				if(this.oncheck1==1){n1=this.s1;this.oncheck1=0;}
				for(int n2=1;n2<=36;)
				{
					if(this.oncheck2==1){n2=this.s2;this.oncheck2=0;}
					if(n2!=n1)
					{
						for(int n3=1;n3<=36;)
						{
							if(this.oncheck3==1){n3=this.s3;this.oncheck3=0;}
							if((n3!=n1)&&(n3!=n2))
							{
								if(c3!=1)
								{
									n4(c6,c5,c4,c3,n3,n2,n1);									
								}
								else
								{
									if(((n3-n2==1)&&(n2-n1==1))||((n1-n2==1)&&(n2-n3==1))){}
									else{n4(c6,c5,c4,c3,n3,n2,n1);}
								}
							}							
							n3++;
						}						
					}
					n2++;
				}				
				n1++;
			}			
			this.oleDbConnection1.Close();
		}

		void nfin(int n7,int n6,int n5,int n4,int n3,int n2,int n1)
		{
			this.s1=n1;this.s2=n2;this.s3=n3;this.s4=n4;this.s5=n5;this.s6=n6;this.s7=n7;
			this.oleDbCommand1.CommandText="INSERT INTO table1 (no1,no2,no3,no4,no5,no6,no7,s,date1) VALUES('"+n1.ToString()+"','"+n2.ToString()+"','"+n3.ToString()+"','"+n4.ToString()+"','"+n5.ToString()+"','"+n6.ToString()+"','"+n7.ToString()+"','0','未定')";
			this.oleDbCommand1.ExecuteNonQuery();			
		}
		void t3(int n7,int n6,int n5,int n4,int n3,int n2,int n1)
		{
			if(this.textBox3.Text.Length<1)
			{
				this.ttt3=0;
				nfin(n7,n6,n5,n4,n3,n2,n1);				
			}
			else
			{
				this.ttt3=int.Parse(this.textBox3.Text);
				int []m={0,0,0,0,0,0,0,0};
				if(n1<10){m[1]=n1;}
				else if((n1>=10)&&(n1<20)){m[1]=n1-10;}
				else if((n1>=20)&&(n1<30)){m[1]=n1-20;}					
				else{m[1]=n1-30;}
				if(n2<10){m[2]=n2;}
				else if((n2>=10)&&(n2<20)){m[2]=n2-10;}
				else if((n2>=20)&&(n2<30)){m[2]=n2-20;}
				else{m[2]=n2-30;}
				if(n3<10){m[3]=n3;}
				else if((n3>=10)&&(n3<20)){m[3]=n3-10;}
				else if((n3>=20)&&(n3<30)){m[3]=n3-20;}
				else{m[3]=n3-30;}
				if(n4<10){m[4]=n4;}
				else if((n4>=10)&&(n4<20)){m[4]=n4-10;}
				else if((n4>=20)&&(n4<30)){m[4]=n4-20;}
				else{m[4]=n4-30;}
				if(n5<10){m[5]=n5;}
				else if((n5>=10)&&(n5<20)){m[5]=n5-10;}
				else if((n5>=20)&&(n5<30)){m[5]=n5-20;}
				else{m[5]=n5-30;}
				if(n6<10){m[6]=n6;}
				else if((n6>=10)&&(n6<20)){m[6]=n6-10;}
				else if((n6>=20)&&(n6<30)){m[6]=n6-20;}
				else{m[6]=n6-30;}
				if(n7<10){m[7]=n7;}
				else if((n7>=10)&&(n7<20)){m[7]=n7-10;}
				else if((n7>=20)&&(n7<30)){m[7]=n7-20;}
				else{m[7]=n7-30;}
				
				if(int.Parse(this.textBox3.Text)==2)
				{
					for(int xx=1;xx<7;)
					{
						if((m[xx]-m[xx+1]==1)||(m[xx+1]-m[xx]==1)){break;}
						xx++;
						if(xx==7){nfin(n7,n6,n5,n4,n3,n2,n1);}
					}
				}
				else if(int.Parse(this.textBox3.Text)==3)
				{
					for(int xx=1;xx<6;)
					{
						if(((m[xx]-m[xx+1]==1)&&(m[xx+1]-m[xx+2]==1))||((m[xx+1]-m[xx]==1)&&(m[xx+2]-m[xx+1]==1))){break;}
						xx++;
						if(xx==6){nfin(n7,n6,n5,n4,n3,n2,n1);}
					}
				}
				else if(int.Parse(this.textBox3.Text)==4)
				{
					for(int xx=1;xx<5;)
					{
						if(((m[xx]-m[xx+1]==1)&&(m[xx+1]-m[xx+2]==1)&&(m[xx+2]-m[xx+3]==1))||((m[xx+1]-m[xx]==1)&&(m[xx+2]-m[xx+1]==1)&&(m[xx+3]-m[xx+2]==1))){break;}
						xx++;
						if(xx==5){nfin(n7,n6,n5,n4,n3,n2,n1);}
					}
				}
				else if(int.Parse(this.textBox3.Text)==5)
				{
					for(int xx=1;xx<4;)
					{
						if(((m[xx]-m[xx+1]==1)&&(m[xx+1]-m[xx+2]==1)&&(m[xx+2]-m[xx+3]==1)&&(m[xx+3]-m[xx+4]==1))||((m[xx+1]-m[xx]==1)&&(m[xx+2]-m[xx+1]==1)&&(m[xx+3]-m[xx+2]==1)&&(m[xx+4]-m[xx+3]==1))){break;}
						xx++;
						if(xx==4){nfin(n7,n6,n5,n4,n3,n2,n1);}
					}
				}
				else if(int.Parse(this.textBox3.Text)==6)
				{
					for(int xx=1;xx<3;)
					{
						if(((m[xx]-m[xx+1]==1)&&(m[xx+1]-m[xx+2]==1)&&(m[xx+2]-m[xx+3]==1)&&(m[xx+3]-m[xx+4]==1)&&(m[xx+4]-m[xx+5]==1))||((m[xx+1]-m[xx]==1)&&(m[xx+2]-m[xx+1]==1)&&(m[xx+3]-m[xx+2]==1)&&(m[xx+4]-m[xx+3]==1)&&(m[xx+5]-m[xx+4]==1))){break;}
						xx++;
						if(xx==3){nfin(n7,n6,n5,n4,n3,n2,n1);}
					}
				}
				else if(int.Parse(this.textBox3.Text)==7)
				{
					for(int xx=1;xx<2;)
					{
						if(((m[xx]-m[xx+1]==1)&&(m[xx+1]-m[xx+2]==1)&&(m[xx+2]-m[xx+3]==1)&&(m[xx+3]-m[xx+4]==1)&&(m[xx+4]-m[xx+5]==1)&&(m[xx+5]-m[xx+6]==1))||((m[xx+1]-m[xx]==1)&&(m[xx+2]-m[xx+1]==1)&&(m[xx+3]-m[xx+2]==1)&&(m[xx+4]-m[xx+3]==1)&&(m[xx+5]-m[xx+4]==1)&&(m[xx+6]-m[xx+5]==1))){break;}
						xx++;
						if(xx==2){nfin(n7,n6,n5,n4,n3,n2,n1);}						
					}
				}
			}
		}
		void t2(int n7,int n6,int n5,int n4,int n3,int n2,int n1)
		{
			if(this.textBox2.Text.Length<1)
			{
				ttt2=0;
				t3(n7,n6,n5,n4,n3,n2,n1);
			}
			else
			{
				ttt2=int.Parse(this.textBox2.Text);
				int []m={0,0,0,0,0,0,0,0};
				if(n1<10){m[1]=n1;}
				else if((n1>=10)&&(n1<20)){m[1]=n1-10;}
				else if((n1>=20)&&(n1<30)){m[1]=n1-20;}					
				else{m[1]=n1-30;}
				if(n2<10){m[2]=n2;}
				else if((n2>=10)&&(n2<20)){m[2]=n2-10;}
				else if((n2>=20)&&(n2<30)){m[2]=n2-20;}
				else{m[2]=n2-30;}
				if(n3<10){m[3]=n3;}
				else if((n3>=10)&&(n3<20)){m[3]=n3-10;}
				else if((n3>=20)&&(n3<30)){m[3]=n3-20;}
				else{m[3]=n3-30;}
				if(n4<10){m[4]=n4;}
				else if((n4>=10)&&(n4<20)){m[4]=n4-10;}
				else if((n4>=20)&&(n4<30)){m[4]=n4-20;}
				else{m[4]=n4-30;}
				if(n5<10){m[5]=n5;}
				else if((n5>=10)&&(n5<20)){m[5]=n5-10;}
				else if((n5>=20)&&(n5<30)){m[5]=n5-20;}
				else{m[5]=n5-30;}
				if(n6<10){m[6]=n6;}
				else if((n6>=10)&&(n6<20)){m[6]=n6-10;}
				else if((n6>=20)&&(n6<30)){m[6]=n6-20;}
				else{m[6]=n6-30;}
				if(n7<10){m[7]=n7;}
				else if((n7>=10)&&(n7<20)){m[7]=n7-10;}
				else if((n7>=20)&&(n7<30)){m[7]=n7-20;}
				else{m[7]=n7-30;}
				for(int aaa=0;aaa<10;)
				{
					int ac=0;
					int tt=0;
					for(int xx=1;xx<8;)
					{									
						if(m[xx]==aaa)
						{ac++;}
						xx++;
						//									if((aaa==9)&&(xx==8))
						//									{
						//										this.oleDbCommand1.CommandText="INSERT INTO table1 (no1,no2,no3,no4,no5,no6,no7,s,date1) VALUES('"+n1.ToString()+"','"+n2.ToString()+"','"+n3.ToString()+"','"+n4.ToString()+"','"+n5.ToString()+"','"+n6.ToString()+"','"+n7.ToString()+"','0','未定')";
						//										this.oleDbCommand1.ExecuteNonQuery();
						//									}
					}
					if(ac>=int.Parse(this.textBox2.Text))
					{
						break;
						tt=1;
					}
					if(tt==1){break;}
					aaa++;
					if(aaa==10)
					{
						t3(n7,n6,n5,n4,n3,n2,n1);
					}
				}									
			}

		}
		void n8(int n7,int n6,int n5,int n4,int n3,int n2,int n1)
		{
			int tong=0;
			if(this.textBox1.Text.Length<1)
			{
				ttt1=0;
				t2(n7,n6,n5,n4,n3,n2,n1);
			}
			else
			{
				ttt1=int.Parse(this.textBox1.Text);
				if(int.Parse(this.textBox1.Text)>1)
				{
					tong=int.Parse(this.textBox1.Text);					
					int m10=0;
					int m20=0;
					int m30=0;
					int m36=0;					
					if(n1<10){m10++;}
					else if((n1>=10)&&(n1<20)){m20++;}
					else if((n1>=20)&&(n1<30)){m30++;}					
					else{m36++;}
					if(n2<10){m10++;}
					else if((n2>=10)&&(n2<20)){m20++;}
					else if((n2>=20)&&(n2<30)){m30++;}
					else{m36++;}
					if(n3<10){m10++;}
					else if((n3>=10)&&(n3<20)){m20++;}
					else if((n3>=20)&&(n3<30)){m30++;}
					else{m36++;}
					if(n4<10){m10++;}
					else if((n4>=10)&&(n4<20)){m20++;}
					else if((n4>=20)&&(n4<30)){m30++;}
					else{m36++;}
					if(n5<10){m10++;}
					else if((n5>=10)&&(n5<20)){m20++;}
					else if((n5>=20)&&(n5<30)){m30++;}
					else{m36++;}
					if(n6<10){m10++;}
					else if((n6>=10)&&(n6<20)){m20++;}
					else if((n6>=20)&&(n6<30)){m30++;}
					else{m36++;}
					if(n7<10){m10++;}
					else if((n7>=10)&&(n7<20)){m20++;}
					else if((n7>=20)&&(n7<30)){m30++;}
					else{m36++;}

					if(m10>=tong||m20>=tong||m30>=tong||m36>=tong){}
					else
					{
						t2(n7,n6,n5,n4,n3,n2,n1);						
					}
				}
				else
				{
					t2(n7,n6,n5,n4,n3,n2,n1);
				}

			}
		}
		void n7(int c6,int c5,int c4,int c3,int n6,int n5,int n4,int n3,int n2,int n1)
		{
			for(int n7=1;n7<=36;)
			{
				if(this.oncheck7==1){n7=this.s7+1;this.oncheck7=0;}
				if((n7!=n1)&&(n7!=n2)&&(n7!=n3)&&(n7!=n4)&&(n7!=n5)&&(n7!=n6))
				{
					if(c3!=1)
					{
						this.n8(n7,n6,n5,n4,n3,n2,n1);																			
					}
					else
					{
						if(((n7-n6==1)&&(n6-n5==1))||((n5-n6==1)&&(n6-n7==1))){}
						else
						{
							this.n8(n7,n6,n5,n4,n3,n2,n1);
						}
					}
				}
				n7++;
			}
		}
		void n6(int c6,int c5,int c4,int c3,int n5,int n4,int n3,int n2,int n1)
		{
			for(int n6=1;n6<=36;)
			{
				if(this.oncheck6==1){n6=this.s6;this.oncheck6=0;}
				if((n6!=n1)&&(n6!=n2)&&(n6!=n3)&&(n6!=n4)&&(n6!=n5))
				{
					if(c3!=1)
					{																	
						n7(c6,c5,c4,c3,n6,n5,n4,n3,n2,n1);
					}
					else
					{
						if(((n6-n5==1)&&(n5-n4==1))||((n4-n5==1)&&(n5-n6==1))){}
						else
						{
							n7(c6,c5,c4,c3,n6,n5,n4,n3,n2,n1);
						}
					}
				}				
				n6++;
			}
		}
		void n5(int c6,int c5,int c4,int c3,int n4,int n3,int n2,int n1)
		{
			for(int n5=1;n5<=36;)
			{
				if(this.oncheck5==1){n5=this.s5;this.oncheck5=0;}
				if((n5!=n1)&&(n5!=n2)&&(n5!=n3)&&(n5!=n4))
				{
					if(c3!=1)
					{
						n6(c6,c5,c4,c3,n5,n4,n3,n2,n1);															
					}
					else
					{
						if(((n5-n4==1)&&(n4-n3==1))||((n3-n4==1)&&(n4-n5==1))){}
						else{n6(c6,c5,c4,c3,n5,n4,n3,n2,n1);}
					}
				}				
				n5++;
			}
		}
		void n4(int c6,int c5,int c4,int c3,int n3,int n2,int n1)
		{
			for(int n4=1;n4<=36;)
			{
				if(this.oncheck4==1){n4=this.s4;this.oncheck4=0;}
				if((n4!=n1)&&(n4!=n2)&&(n4!=n3))
				{
					if(c3!=1)
					{
						n5(c6,c5,c4,c3,n4,n3,n2,n1);												
					}
					else
					{
						if(((n4-n3==1)&&(n3-n2==1))||((n2-n3==1)&&(n3-n4==1))){}
						else{n5(c6,c5,c4,c3,n4,n3,n2,n1);}
					}
				}				
				n4++;
			}
		}
		private void button1_Click(object sender, System.EventArgs e)
		{
			//this.oThread= new Thread(new ThreadStart(this.nb));
		
			try
			{
				if(!oThread.IsAlive)
				{
　　　　　　　　oThread.Start();
				}
			}
			catch{}
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			try
			{
            　oThread.Sleep(1);
				oThread.Suspend();
			}
			catch{}
		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			try
			{
				oThread.Resume();
			}
			catch{}
		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			try
			{
				this.label1.Text=this.oThread.ThreadState.ToString()+" "+s1.ToString()+" "+s2.ToString()+" "+s3.ToString()+" "+s4.ToString()+" "+s5.ToString()+" "+s6.ToString()+" "+s7.ToString();
			}
			catch{}
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			try
			{				
				oThread.Abort();				
				try{this.oleDbConnection1.Close();}
				catch{}
				try
				{
					FileStream input1=new FileStream(Directory.GetCurrentDirectory()+"\\"+"dl.dat",FileMode.OpenOrCreate,FileAccess.ReadWrite);
					System.Text.Encoding en1=System.Text.Encoding.GetEncoding("gb2312");
					StreamWriter sw=new StreamWriter(input1,en1);
					sw.WriteLine("sti="+this.lll3.ToString()+","+this.ttt1.ToString()+","+this.ttt2.ToString()+","+this.ttt3.ToString()+";\r\n");
					sw.WriteLine("nume="+this.s1.ToString()+","+this.s2.ToString()+","+this.s3.ToString()+","+this.s4.ToString()+","+this.s5.ToString()+","+this.s6.ToString()+","+this.s7.ToString()+";\r\n");					
					sw.Close();
				}
				catch{}
			}
			catch{}
		}

		private void button6_Click(object sender, System.EventArgs e)
		{
			try
			{
				string check;
				FileStream input=new FileStream(Directory.GetCurrentDirectory()+"\\"+"dl.dat",FileMode.Open,FileAccess.Read);
				System.Text.Encoding en=System.Text.Encoding.GetEncoding("gb2312");
				StreamReader sr=new StreamReader(input,en);
				check=sr.ReadToEnd();			
				int stic=check.IndexOf("sti=",0);
				int numec=check.IndexOf("nume=",0);
	
			    int d1,d2,d3,d4,d5,d6,d7;
			    d1=check.IndexOf(",",numec);
			    d2=check.IndexOf(",",d1+1);
			    d3=check.IndexOf(",",d2+1);
			    d4=check.IndexOf(",",d3+1);
			    d5=check.IndexOf(",",d4+1);
			    d6=check.IndexOf(",",d5+1);
			    d7=check.IndexOf(";",d6+1);


				if(check.Substring(stic+4,1)=="1"){this.checkBox4.Checked=true;}
				if(check.Substring(stic+6,1)!="0"){this.textBox1.Text=check.Substring(stic+6,1);}
				if(check.Substring(stic+8,1)!="0"){this.textBox2.Text=check.Substring(stic+8,1);}
				if(check.Substring(stic+10,1)!="0"){this.textBox3.Text=check.Substring(stic+10,1);}
		
				if(check.Substring(numec+5,check.IndexOf(",",numec)-(numec+5))!="0"){this.s1=int.Parse(check.Substring(numec+5,check.IndexOf(",",numec)-(numec+5))); }
			    if(check.Substring(d1+1,d2-d1-1)!="0"){this.s2=int.Parse(check.Substring(d1+1,d2-d1-1)); }
			    if(check.Substring(d2+1,d3-d2-1)!="0"){this.s3=int.Parse(check.Substring(d2+1,d3-d2-1)); }
			    if(check.Substring(d3+1,d4-d3-1)!="0"){this.s4=int.Parse(check.Substring(d3+1,d4-d3-1)); }
			    if(check.Substring(d4+1,d5-d4-1)!="0"){this.s5=int.Parse(check.Substring(d4+1,d5-d4-1)); }
			    if(check.Substring(d5+1,d6-d5-1)!="0"){this.s6=int.Parse(check.Substring(d5+1,d6-d5-1)); }
			    if(check.Substring(d6+1,d7-d6-1)!="0"){this.s7=int.Parse(check.Substring(d6+1,d7-d6-1)); }
			    
				this.label1.Text=this.s1.ToString()+","+this.s2.ToString()+","+this.s3.ToString()+","+this.s4.ToString()+","+this.s5.ToString()+","+this.s6.ToString()+","+this.s7.ToString();
			    this.oncheck1=1;
			    this.oncheck2=1;
			    this.oncheck3=1;
			    this.oncheck4=1;
			    this.oncheck5=1;
			    this.oncheck6=1;
			    this.oncheck7=1;
			
            	sr.Close();
			}
			catch
			{
				MessageBox.Show("无法打开连接，确认是否执行文件目录中含有dl.dat；确认是否该连接有效（打开dl.dll查看是否有效）","无效操作");
			}
		}

		private void button7_Click(object sender, System.EventArgs e)
		{
			this.button1_Click(this,e);
		}
//			try
//			{
//				this.oleDbCommand1.ExecuteNonQuery();
//			}catch{ this.label1.Text=this.oleDbCommand1.CommandText;}
	}
}
