using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HF07_House
{
    public partial class Form1 : Form
    {
        Location currentLocation;
        RoomWithDoor livingRoom;
        RoomWithDoor kitchen;
        Room dinnerRoom;
        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace mainBedroom;
        RoomWithHidingPlace secondBedroom;
        OutsideWithHidingPlace driveway;
        Oponent oponent;
        int Moves;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            oponent = new Oponent(frontYard);
            ResetGame(false);
        }

        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show("Меня нашли за " + Moves + " шагов");
                IHidingPlace place = currentLocation as IHidingPlace;
                description.Text = "Соперник прятался за " + place.HidingPlace;
            }
            Moves = 0;
            hide.Visible = true;
            goHere.Visible = false;
            check.Visible = false;
            goThroughTheDoor.Visible = false;
            exists.Visible = false;
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Гостинная", "старинный ковер", "в гардеробе","дубовая дверь " +
                "с латунной руской");
            dinnerRoom = new Room("Столовая", "стол со скатертью");
            kitchen = new RoomWithDoor("Кухня", "веер с павлином", "в сундуке","металлическая дверь");
            frontYard = new OutsideWithDoor("Лужайка", false, "Стеклянная дверь");
            backYard = new OutsideWithDoor("Задний двор", true, "Деревянная дверь");
            garden = new Outside("Сад", false);
            stairs = new Room("Лестница", "деревянные перила");
            hallway = new RoomWithHidingPlace("Коридор", "картина с собакой", "в гардеробе");
            bathroom = new RoomWithHidingPlace("Ванная", "раковина с туалетом", "в душевой кабине");
            mainBedroom = new RoomWithHidingPlace("Основная спальня", "большая кровать",
                "под кроватью");
            secondBedroom = new RoomWithHidingPlace("Вторая спальня", "маленькая кровать",
                "под кроватью");
            driveway = new OutsideWithHidingPlace("Подъезд", true, "под лестницей");

            livingRoom.Exists = new Location[] { dinnerRoom, stairs };
            dinnerRoom.Exists = new Location[] { livingRoom, kitchen };
            kitchen.Exists = new Location[] { dinnerRoom };
            backYard.Exists = new Location[] { garden, frontYard };
            garden.Exists = new Location[] { frontYard, backYard };
            frontYard.Exists = new Location[] { backYard, garden };
            stairs.Exists = new Location[] { hallway, livingRoom };
            hallway.Exists = new Location[] { stairs, mainBedroom, secondBedroom, bathroom };
            bathroom.Exists = new Location[] { hallway };
            mainBedroom.Exists = new Location[] { hallway };
            secondBedroom.Exists = new Location[] { hallway };
            driveway.Exists = new Location[] { backYard, frontYard };

            livingRoom.DoorLocation = frontYard;
            kitchen.DoorLocation = backYard;

            frontYard.DoorLocation = livingRoom;
            backYard.DoorLocation = kitchen;
        }

        private void MoveToANewLocation(Location location)
        {
            Moves++;
            currentLocation = location;
            RedrawForm();
        }

        private void RedrawForm()
        {
            exists.Items.Clear();
            foreach (var item in currentLocation.Exists)
            {
                exists.Items.Add(item.Name);
            }
            exists.SelectedIndex = 0;
            description.Text = currentLocation.Description + "\r\n перемещение #" + Moves;
            if (currentLocation is IHidingPlace)
            {
                IHidingPlace place = currentLocation as IHidingPlace;
                check.Text = "Check (" + place.HidingPlace + ")"; goThroughTheDoor.Visible
                    = (currentLocation is IHasExteriorDoor) ? true : false;
            }
        }

        private void goHere_Click(object sender, EventArgs e)
        {
            var index = exists.SelectedIndex;
            MoveToANewLocation(currentLocation.Exists[index]);
            if (currentLocation is IHidingPlace)
            {
                check.Visible = true;
            }
            else
            {
                check.Visible = false;
            }
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            if (currentLocation is IHasExteriorDoor)
            {
                IHasExteriorDoor hasExteriorDoor = currentLocation as IHasExteriorDoor;
                MoveToANewLocation(hasExteriorDoor.DoorLocation);
            }
            if (currentLocation is IHidingPlace)
            {
                check.Visible = true;
            }
            else
            {
                check.Visible = false;
            }
        }

        private void check_Click(object sender, EventArgs e)
        {
            Moves++;
            if (oponent.Check(currentLocation))
            {
                ResetGame(true);
            }
            else
            {
                RedrawForm();
            }
        }

        private void hide_Click(object sender, EventArgs e)
        {
            hide.Visible = false;

            for (int i = 0; i < 10; i++)
            {
                oponent.Move();
                description.Text = i + "...";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }

            description.Text = "Я иду искать!";

            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            goHere.Visible = true;
            exists.Visible = true;
            MoveToANewLocation(livingRoom);
        }
    }
}
