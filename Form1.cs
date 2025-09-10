using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace Emia_Calculator_App_CS345
{
    public partial class Form1 : Form{
        bool isClearingBox = false;
        public Form1(){
            InitializeComponent();
        }

        private void checkIsClearing() { 
            if (isClearingBox || equationBox.Text == "Infinity"){
                clearEquationBox(null,null);
                isClearingBox=false;
            }
        }

        private void numberButtonClicked(object sender, EventArgs e) {
            checkIsClearing();
            equationBox.Text = equationBox.Text + ((Button)sender).Text;
        }
        private void backspaceClicked(object sender, EventArgs e) {
            String expression = equationBox.Text;
            if(expression.Length > 0) {
                equationBox.Text = expression.Substring(0, expression.Length - 1);
            }
        }
        private void dotButtonClicked(object sender, EventArgs e){
            String expression = equationBox.Text;
            int size = equationBox.Text.Length;
            for(int i = size - 1;i >= 0; i--){
                if (expression[i].Equals('.')){
                    Console.WriteLine("Found a period");
                    return;

                } else if (!Char.IsDigit(expression[i])){
                    break;
                }
            }
            equationBox.Text += '.';
        }
        private void equalsButtonClicked(object sender, EventArgs e){
            String expression = equationBox.Text;
            expression = expression.Replace("÷", "/");
            expression = expression.Replace("×", "*");
            try {
                String result = new DataTable().Compute(expression, "").ToString();
                equationBox.Text = result;
                if(result == "Infinity") isClearingBox = true;

            } catch (Exception ex){
                showMessage("Error");
            }
            
        }

        private void operatorButtonClicked(object sender, EventArgs e){
            if ( isClearingBox ) {
                checkIsClearing();
                return;
            }
            String expression = equationBox.Text;
            if(expression.Length == 0) { return; }
            Char last_element = expression[expression.Length - 1];
            if (!Char.IsDigit(last_element) && last_element != ')'){
                equationBox.Text = expression.Substring(0, expression.Length - 1);
            }
            equationBox.Text += ((Button)sender).Text;
           

        }


        private void showMessage(String message){
            equationBox.Text = message;
            isClearingBox = true;
        }

        private void clearEquationBox(object sender, EventArgs e){
            equationBox.Text = "";
        }

    }
}
