﻿using System;
using System.Windows.Forms;
using virtual_receptionist.Controllers;

namespace virtual_receptionist.Views
{
    /// <summary>
    /// Foglalási napló ablak
    /// </summary>
    public partial class FormBooking : Form
    {
        #region Adattagok

        /// <summary>
        /// Foglalási napló vezérlő egy példánya
        /// </summary>
        private BookingController controller;

        #endregion

        #region Konstruktor

        /// <summary>
        /// Foglalási napló ablak konstruktora
        /// </summary>
        public FormBooking()
        {
            InitializeComponent();

            controller = new BookingController();
        }

        #endregion

        #region UI események

        private void FormBooking_Load(object sender, EventArgs e)
        {
            DateTime actualDate = dateTimePickerArrivalDate.Value;
            dataGridViewBookings.DataSource = controller.GetBookingsByArrivalDate(actualDate);
        }

        private void dateTimePickerArrivalDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime arrivalDate = dateTimePickerArrivalDate.Value;
            dataGridViewBookings.DataSource = controller.GetBookingsByArrivalDate(arrivalDate);
        }

        private void dateTimePickerDepartureDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime departureDate = dateTimePickerDepartureDate.Value;
            dataGridViewBookings.DataSource = controller.GetBookingsByDepartureDate(departureDate);
        }

        private void buttonNewBooking_Click(object sender, EventArgs e)
        {
            FormAddBooking formAddBooking = new FormAddBooking();

            if (formAddBooking.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Foglalás sikeresen rögzítésre került!", "", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void buttonUpdateBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                object id = dataGridViewBookings.SelectedRows[0].Cells[0].Value;
                object guest = dataGridViewBookings.SelectedRows[0].Cells[1].Value;
                object room = dataGridViewBookings.SelectedRows[0].Cells[2].Value;
                object numberOfGuests = dataGridViewBookings.SelectedRows[0].Cells[3].Value;
                object arrivalDate = dataGridViewBookings.SelectedRows[0].Cells[4].Value;
                object departureDate = dataGridViewBookings.SelectedRows[0].Cells[5].Value;

                FormUpdateBooking formUpdateBooking =
                    new FormUpdateBooking(id, guest, room, numberOfGuests, arrivalDate, departureDate);

                if (formUpdateBooking.ShowDialog() == DialogResult.OK)
                {
                    object[] booking = formUpdateBooking.Booking;

                    dataGridViewBookings.SelectedRows[0].Cells[0].Value = booking[0];
                    dataGridViewBookings.SelectedRows[0].Cells[1].Value = booking[1];
                    dataGridViewBookings.SelectedRows[0].Cells[2].Value = booking[2];
                    dataGridViewBookings.SelectedRows[0].Cells[3].Value = booking[3];
                    dataGridViewBookings.SelectedRows[0].Cells[4].Value = booking[4];
                    dataGridViewBookings.SelectedRows[0].Cells[5].Value = booking[5];

                    MessageBox.Show("A foglalás sikeresen módosult!", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölt foglalás!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteBooking_Click(object sender, EventArgs e)
        {
            if (dataGridViewBookings.SelectedRows.Count > 0)
            {
                DialogResult delete = MessageBox.Show("Biztosan törli a kijelölt foglalást?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (delete == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(dataGridViewBookings.SelectedRows[0].Cells[0].Value);

                    int row = dataGridViewBookings.SelectedRows[0].Index;
                    dataGridViewBookings.Rows.RemoveAt(row);

                    controller.DeleteBooking(id);

                    MessageBox.Show("A foglalás sikeresen törlésre került!", "", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölt foglalás!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion
    }
}
