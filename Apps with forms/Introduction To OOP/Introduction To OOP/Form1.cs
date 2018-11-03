using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Introduction_To_OOP
{
    public partial class MainForm : Form
    {

        int Difficulty = 0;
        int Progress;
        public MainForm()
        {
            InitializeComponent();
            LoadProgress();
            UpdateProgress();
        }


        private void LoadProgress()
        {
            string path = Environment.CurrentDirectory + "Progress.txt";
            if (System.IO.File.Exists(path))
                {
                using (System.IO.StreamReader file = new System.IO.StreamReader(path))
                {
                    string a = file.ReadLine();
                    Progress = Int32.Parse(a);
                    file.Close();
                }
            }
            else
            {
                File.Create(path);
                Progress = 0;
            }
        }

        private void SaveProgress()
        {
            string path = Environment.CurrentDirectory + "Progress.txt";
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path))
            {
                file.Write(Progress);
                file.Close();
            }
        }

        private void UpdateProgress()
        {
            Label[] labels = { lblProgress0, lblProgress1, lblProgress2, lblProgress3, lblProgress4, lblProgress5, lblProgress6, lblProgress7, lblProgress8 };
            for (int i = 0; i<Progress; i++)
            {
                
                labels[i].BackColor = Color.Green;
            }
            switch (Progress)
            {
                case 0:
                    btnIntermediate.Visible = false;
                    btnAdvanced.Visible = false;
                    btnTopic2.Visible = false;
                    btnTopic3.Visible = false;
                    break;
                case 1:
                    btnTopic2.Visible = true;

                    btnIntermediate.Visible = false;
                    btnAdvanced.Visible = false;
                    btnTopic3.Visible = false;
                    break;
                case 2:
                    btnTopic2.Visible = true;
                    btnTopic3.Visible = true;

                    btnIntermediate.Visible = true;
                    btnAdvanced.Visible = false;
                    break;
                case 3:
                    btnAdvanced.Visible = false;
                    if (Difficulty != 0)
                    {
                        btnTopic2.Visible = false;
                        btnTopic3.Visible = false;
                    }
                    else
                    {
                        btnTopic2.Visible = true;
                        btnTopic3.Visible = true;
                    }
                    break;
                case 4:
                    btnTopic2.Visible = true;

                    btnAdvanced.Visible = false;
                    if (Difficulty != 0)
                    {
                        btnTopic3.Visible = false;
                    }
                    else
                    {
                        btnTopic3.Visible = true;
                    }
                    break;
                case 5:
                    btnTopic2.Visible = true;
                    btnTopic3.Visible = true;

                    btnAdvanced.Visible = true;
                    break;
                case 6:
                    btnTopic2.Visible = true;

                    if (Difficulty == 2)
                    {
                        btnTopic2.Visible = false;
                        btnTopic3.Visible = false;
                    }
                    else
                    {
                        btnTopic2.Visible = true;
                        btnTopic3.Visible = true;
                    }
                    break;
                case 7:
                    btnTopic2.Visible = true;
                    btnTopic3.Visible = true;

                    if (Difficulty == 2)
                    {
                        btnTopic3.Visible = false;
                    }
                    else
                    {
                        btnTopic3.Visible = true;
                    }
                    break;
                case 8:
                    break;
            }
            SaveProgress();
        }
        #region generic buttons
        private void btnBeginner_Click(object sender, EventArgs e)
        {
            tabMain.Hide();
            Difficulty = 0;
            InitializeSections();
            UpdateProgress();
            tabSections.Show();
        }

        private void btnIntermediate_Click(object sender, EventArgs e)
        {
            tabMain.Hide();
            Difficulty = 1;
            InitializeSections();
            UpdateProgress();
            tabSections.Show();
        }

        private void btnAdvanced_Click(object sender, EventArgs e)
        {
            tabMain.Hide();
            Difficulty = 2;
            InitializeSections();
            UpdateProgress();
            tabSections.Show();
        }

        private void btnProgress_Click(object sender, EventArgs e)
        {
            tabMain.Hide();
            tabProgress.Show();
        }
        
        private void btnBackSec_Click(object sender, EventArgs e)
        {
            tabSections.Hide();
            tabMain.Show();
        }

        private void btnBackPro_Click(object sender, EventArgs e)
        {
            tabProgress.Hide();
            tabMain.Show();
        }

        private void btnBackAct_Click(object sender, EventArgs e)
        {
            tabTopic.Hide();
            tabSections.Show();
        }

        private void btnTopic1_Click(object sender, EventArgs e)
        {
            InitializeTopic1();
            tabSections.Hide();
            tabTopic.Show();
        }

        private void btnTopic2_Click(object sender, EventArgs e)
        {
            InitializeTopic2();
            tabSections.Hide();
            tabTopic.Show();
        }

        private void btnTopic3_Click(object sender, EventArgs e)
        {
            InitializeTopic3();
            tabSections.Hide();
            tabTopic.Show();
        }
        #endregion
        public void InitializeSections()
        {
            switch (Difficulty)
            {
                case 0:
                    lblSection1.Text = "Classes and Objects";
                    lblSection2.Text = "Instantiation";
                    lblSection3.Text = "Constructors";
                    break;
                case 1:
                    lblSection1.Text = "Inheritance";
                    lblSection2.Text = "Method overriding and overloading";
                    lblSection3.Text = "Encapsulation and abstraction";
                    break;
                case 2:
                    lblSection1.Text = "Polymorphism";
                    lblSection2.Text = "Composition";
                    lblSection3.Text = "Aggregation and association";
                    break;
            }
        }

        public void InitializeTopic1()
        {
            switch (Difficulty)
            {
                case 0:
                    lblTopicTitle.Text = "What are classes and objects?";
                    lblTopicContent1.Text = "A class is like a template or blueprints for an object. Classes contain the methods (similar to functions and procedures) and attributes (variables) that an object made from that class will contain. Classes do not actually exist in memory during the running of a program. Objects made from classes however, do exist and can be used once instantiated (this will be covered in the next topic).";
                    lblTopicContent2.Text = "Throughout this program, you will be given examples using the idea of message decoders. In the above example, a class for a specific message decoder is created. An object of the message is then created from this class and can be used to decode messages using the methods and attributes provided by the class.";
                    // pbAct.ImageLocation = "";

                    break;
                case 1:
                    lblTopicTitle.Text = "Inheritance";
                    lblTopicContent1.Text = @"Imagine you had a number of classes which had a lot of the same properties and methods but had slight differences. To avoid having to repeat all those properties and methods for each class, inheritance is used.
Through inheritance, a class and its objects can hold the properties and methods of a different class. The class which is inherited from is known as the base, super or parent class.";
                    lblTopicContent2.Text = "In the above example, the longStringMessageDecoder inherits from the stringMessageDecoder as it is mostly the same but requires a few changes to the method.";

                    break;
                case 2:
                    lblTopicTitle.Text = "Polymorphism";
                    lblTopicContent1.Text = "Polymorphism translates from Greek as 'Many forms'. In OOP, this refers to methods being able to process an object or data structure differently based on the type of object/data structure. A basic example of this is string manipulation and addition by the same operator. 'string' + 'word' results in 'stringword' whereas 1 + 2 results in 3. In this case, the + operator is performing a different task based on the objects it is dealing with.";
                    lblTopicContent2.Text = "In the above example, the decodeMessage is called for stringMessageDecoder and intMessageDecoder but the method performs a different task on the data based on which object called it.";

                    break;
            }
        } //HERE
    
        public void InitializeTopic2()
        {
            switch (Difficulty)
            {
                case 0:
                    lblTopicTitle.Text = "Instantiation";
                    lblTopicContent1.Text = "Instantiation is the process of creating an object from a class known as an 'instance' of a class. This means that an object now has a place in memory and has its own set of methods and attributes based on the class it was created from. Instantiation is carried out by using the 'new' keyword in most programming language as shown below.";
                    lblTopicContent2.Text = "Continuing with our example of the message decoder, before the decoder object is used, it is instantiated by the code 'new MessageDecoder'. Trying to use an object without first instantiating it would result in a crash.";

                    // pbAct.ImageLocation = "";

                    break;
                case 1:
                    lblTopicTitle.Text = "Method overriding and overloading";
                    lblTopicContent1.Text = @"When a class inherits from a base class, some of the same methods may need to be different to the base class. To achieve this, we use method overriding where we create a new method with the same name as the method in the base class and simply rewrite the method.
Method overloading on the other hand, is where multiple methods of the same name are created within a class but each method takes different types/number of parameters.";
                    lblTopicContent2.Text = "In the above example, ";

                    break;
                case 2:

                    lblTopicTitle.Text = "Composition";
                    lblTopicContent1.Text = "Composition is a concept that is similar to inheritance. It involves including a class or parts of a class in the definition of a class. This is different to inheritance because you can use a desired part of the code in the base class rather than making the entire class a copy of the base class with some differences. The class that compose of each other however, are dependant on one another and must exist at the same time to function.";
                    lblTopicContent2.Text = "";

                    break;
            }
        } //HERE

        public void InitializeTopic3()
        {
            switch (Difficulty)
            {
                case 0:
                    lblTopicTitle.Text = "Constructors";
                    lblTopicContent1.Text = "Constructors are special methods that are run upon the instantiation of an object using the 'new' keyword. A constructor has the same name as the class it is made in. These are often used to set inital values to an object's attributes.";
                    lblTopicContent2.Text = "In the example, a method decoder is instantiated in the code and immediately runs its constructor to assign the inital message to be decoded.";

                    // pbAct.ImageLocation = "";

                    break;
                case 1:
                    lblTopicTitle.Text = "Encapsulation and abstraction";
                    lblTopicContent1.Text = @"Encapsulation is a way of changing the accessibility of properties and fields. This means changing where in a program the field or property can be used. Public and private are two commonly used access modifiers in most OOP languages.
Abstraction is a process whereby unnecesary details are hidden from the program. Encapsulation is a way of achieving abstraction as it hides unnecessary variables and methods which the programmer doesn't need.";
                    lblTopicContent2.Text = "";

                    break;
                case 2:
                    lblTopicTitle.Text = "Aggregation and association";
                    lblTopicContent1.Text = @"Aggregation is a relationship between classes where a class includes (owns) objects of another class. The objects which are owned by the class cannot be owned by any other class however, both objects can exist independently.
Association on the other hand is a relationship where two classes may contain eachother as part of their definition buy they do not need each other to exist. They can exist as independent instances of their classes.";
                    lblTopicContent2.Text = "";

                    break;
            }
        } //HERE
        
        private void btnBackMC_Click(object sender, EventArgs e)
        {
            tabActivityMC.Hide();
            tabTopic.Show();
        }

        private void btnActivityStart_Click(object sender, EventArgs e)
        {
            tabTopic.Hide();
            switch (lblTopicTitle.Text)
            {
                case "What are classes and objects?":
                    ObjectsAndClassesActivity();
                    break;
                case "Instantiation":
                    InstantiationActivity();
                    break;
                case "Constructors":
                    ConstructorsActivity();
                    break;
                case "Inheritance":
                    InheritanceActivity();
                    break;
                case "Method overriding and overloading":
                    MethodsActivity();
                    break;
                case "Encapsulation and encapsulation":
                    EncapsulationActivity();
                    break;
                case "Composition":
                    AggregationActivity();
                    break;
                case "Aggregation and association":
                    AbstractionActivity();
                    break;
                case "Polymorphism":
                    PolymorphismActivity();
                    break;
            }
        }

        #region Activities
        private void ObjectsAndClassesActivity()
        {
            tabActivityMC.Show();
            lblQuestionMC.Text = "Which of the following best describes an object?";
            radMC1.Text = "A class which can be used.";
            radMC2.Text = "Something made using a class as a template.";
            radMC3.Text = "A class with methods and attributes.";
            radMC4.Text = "A template for classes.";
            radMC5.Text = "An array of classes.";
        }

        private void InstantiationActivity()
        {
            tabActivityMatch.Show();
            lblQuestionMC.Text = "Drag the objects on the left to a placeholder in the middle to show if it's instantiated.";
            lblMtchDest1.Text = "Not instantiated";
            lblMtchDest2.Text = "Not instantiated";
            lblMtchDest3.Text = "Not instantiated";
            lblMtchDest4.Text = "Instantiated";
            lblMtchDest5.Text = "Instantiated";
            btnMtch1.Text = "largeObject dinosaur = new largeObject()";
            btnMtch2.Text = "largeObject dinosaur";
            btnMtch3.Text = "Duck Dan = new Duck()";
            btnMtch4.Text = "newObject anObject";
            btnMtch5.Text = "InstantiedObject object";
        }

        private void ConstructorsActivity()
        {
            tabActivityMC.Show();
            lblQuestionMC.Text = "Select the correct definition of a constructor:?";
            radMC1.Text = "A method which is called upon the instantiation of an object.";
            radMC2.Text = "A method which is called when an object is declared.";
            radMC3.Text = "A variable in a class that is used to identify objects.";
            radMC4.Text = "A method in a class which is run everytime an object is used.";
            radMC5.Text = "An identifier for an object which is set upon instantiation.";
        }

        private void InheritanceActivity()
        {
            tabActivityMC.Show();
            lblQuestionMC.Text = "Select the correct definition of inheritance in OOP.";
            radMC1.Text = "An object is provided with the same methods and attributes as a class.";
            radMC2.Text = "An object's attributes' values are passed to another object.";
            radMC3.Text = "When a class' method contains methods of an existing object.";
            radMC4.Text = "A class is provided attributes and methods from a 'base' class which it inherits from.";
            radMC5.Text = "A class is created using an object of another class to provide pre-assigned methods and attributes.";
        }

        private void MethodsActivity()
        {
        }

        private void EncapsulationActivity()
        {
        }

        private void AggregationActivity()
        {
        }

        private void AbstractionActivity()
        {
        }

        private void PolymorphismActivity()
        {
            tabActivityMC.Show();
            lblQuestionMC.Text = "Select the statement below which describes polymorphism:";
            radMC1.Text = "Polymorphism occurs when two different classes have the same attributes.";
            radMC2.Text = "Polymorphism is the idea that objects can be converted into objects of other classes when needed.";
            radMC3.Text = "Polymorphism describes a method being able to process an object differently based on what the object is.";
            radMC4.Text = "Polymorphism is achieved when two or more objects have the same name but perform different tasks.";
            radMC5.Text = "Polymorphism is a situation where a class definition contains an object of another class.";
        }

        #endregion
        private void btnCheckMC_Click(object sender, EventArgs e)
        {
            switch (lblTopicTitle.Text)
            {
                case "What are classes and objects?":
                    if (radMC2.Checked)
                    {
                        pbTick.BringToFront();
                        // Save to file that topic is complete.
                    }
                    else
                    {
                        pbCross.BringToFront();
                    }
                    break;
                case "Constructors":
                    if (radMC1.Checked)
                    {
                        pbTick.BringToFront();
                        // Save to file that topic is complete.
                    }
                    else
                    {
                        pbCross.BringToFront();
                    }
                    break;
                case "Inheritance":
                    if (radMC4.Checked)
                    {
                        pbTick.BringToFront();
                        // Save to file that topic is complete.
                    }
                    else
                    {
                        pbCross.BringToFront();
                    }
                    break;
                case "Polymorphism":
                    if (radMC3.Checked)
                    {
                        pbTick.BringToFront();
                        // Save to file that topic is complete.
                    }
                    else
                    {
                        pbCross.BringToFront();
                    }
                    break;
            }
        }

        private void pbTick_Click(object sender, EventArgs e)
        {
                tabActivityMC.Hide();
                tabSections.Show();
                pbTick.SendToBack();
            switch (Progress)
            {
                case 0:
                    Progress += 1;
                    break;
                case 2:
                    Progress += 1;
                    break;
                case 3:
                    Progress += 1;
                    break;
                case 6:
                    Progress += 1;
                    break;
            }
            UpdateProgress();
        }

        private void pbCross_Click(object sender, EventArgs e)
        {
            pbCross.SendToBack();
        }

        private void btnBackMtch_Click(object sender, EventArgs e)
        {
            tabActivityMatch.Hide();
            tabTopic.Show();
        }

        private void btnCheckMtch_Click(object sender, EventArgs e) // HERE
        {
            switch (lblTopicTitle.Text)
            {
                case "Instantiation":
                    if ((lblMtchOpt4.Text == btnMtch1.Text) || (lblMtchOpt4.Text == btnMtch3.Text))
                    {
                        if ((lblMtchOpt5.Text == btnMtch1.Text) || (lblMtchOpt5.Text == btnMtch3.Text))
                        {
                            pbTickMtch.BringToFront();
                        }
                    }
                    else
                    {
                        pictureBox1.BringToFront();
                    }
                    break;
            }
        }
        
        private void btnMtch1_MouseDown(object sender, MouseEventArgs e)
        {
            var button = (Button)sender;
            button.DoDragDrop(button.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }

        private void lblMtchOpt1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void lblMtchOpt1_DragDrop(object sender, DragEventArgs e)
        {
            var label = (Label)sender;
            label.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void pbTickMtch_Click(object sender, EventArgs e)
        {
            tabActivityMatch.Hide();
            tabSections.Show();
            pbTickMtch.SendToBack();

            switch (Progress)
            {
                case 1:
                    Progress += 1;
                    break;
            }
            UpdateProgress();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.SendToBack();
        }
    }
}
