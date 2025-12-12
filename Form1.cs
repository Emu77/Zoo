
using System;
using System.Windows.Forms;
using Zooverwaltung.Models;
using Zooverwaltung.Repositories;

namespace Zooverwaltung
{
    public partial class Form1 : Form
    {
        private readonly KontinentRepository kontinentRepo = new KontinentRepository();
        private readonly GehegeRepository gehegeRepo = new GehegeRepository();
        private readonly TierartRepository tierartRepo = new TierartRepository();
        private readonly TierRepository tierRepo = new TierRepository();
        private readonly FutterRepository futterRepo = new FutterRepository();
        private readonly FutterrationRepository futterrationRepo = new FutterrationRepository();

        private Kontinent selectedKontinent;
        private Gehege selectedGehege;
        private Tierart selectedTierart;
        private Tier selectedTier;
        private Futter selectedFutter;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadKontinente();
            LoadGehege();
            LoadTierarten();
            LoadTiere();
            LoadFutter();
            LoadRationCombos();
            LoadUebersicht();
        }

        // ===== Kontinente =====
        private void LoadKontinente()
        {
            lstKontinente.DataSource = null;
            lstKontinente.DataSource = kontinentRepo.GetAll();
            lstKontinente.DisplayMember = "Kbezeichnung";
        }

        private void lstKontinente_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedKontinent = lstKontinente.SelectedItem as Kontinent;
            if (selectedKontinent == null) return;
            txtKontinentBezeichnung.Text = selectedKontinent.Kbezeichnung;
        }

        private void btnKontinentSpeichern_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKontinentBezeichnung.Text)) return;

            if (selectedKontinent == null)
            {
                kontinentRepo.Insert(new Kontinent { Kbezeichnung = txtKontinentBezeichnung.Text });
            }
            else
            {
                selectedKontinent.Kbezeichnung = txtKontinentBezeichnung.Text;
                kontinentRepo.Update(selectedKontinent);
            }

            selectedKontinent = null;
            txtKontinentBezeichnung.Clear();
            LoadKontinente();
            LoadGehege();
            LoadUebersicht();
        }

        private void btnKontinentLoeschen_Click(object sender, EventArgs e)
        {
            if (selectedKontinent == null) return;
            kontinentRepo.Delete(selectedKontinent.kID);
            selectedKontinent = null;
            txtKontinentBezeichnung.Clear();
            LoadKontinente();
            LoadGehege();
            LoadUebersicht();
        }

        // ===== Gehege =====
        private void LoadGehege()
        {
            lstGehege.DataSource = null;
            lstGehege.DataSource = gehegeRepo.GetAll();
            lstGehege.DisplayMember = "GBezeichnung";

            cboGehegeKontinent.DataSource = null;
            cboGehegeKontinent.DataSource = kontinentRepo.GetAll();
            cboGehegeKontinent.DisplayMember = "Kbezeichnung";
            cboGehegeKontinent.ValueMember = "kID";
        }

        private void lstGehege_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedGehege = lstGehege.SelectedItem as Gehege;
            if (selectedGehege == null) return;
            txtGehegeBez.Text = selectedGehege.GBezeichnung;
            cboGehegeKontinent.SelectedValue = selectedGehege.KontinentID;
        }

        private void btnGehegeSpeichern_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtGehegeBez.Text) || cboGehegeKontinent.SelectedValue == null) return;

            if (selectedGehege == null)
            {
                gehegeRepo.Insert(new Gehege
                {
                    GBezeichnung = txtGehegeBez.Text,
                    KontinentID = (int)cboGehegeKontinent.SelectedValue
                });
            }
            else
            {
                selectedGehege.GBezeichnung = txtGehegeBez.Text;
                selectedGehege.KontinentID = (int)cboGehegeKontinent.SelectedValue;
                gehegeRepo.Update(selectedGehege);
            }

            selectedGehege = null;
            txtGehegeBez.Clear();
            LoadGehege();
            LoadTiere();
            LoadUebersicht();
        }

        private void btnGehegeLoeschen_Click(object sender, EventArgs e)
        {
            if (selectedGehege == null) return;
            gehegeRepo.Delete(selectedGehege.gID);
            selectedGehege = null;
            txtGehegeBez.Clear();
            LoadGehege();
            LoadTiere();
            LoadUebersicht();
        }

        // ===== Tierarten =====
        private void LoadTierarten()
        {
            lstTierarten.DataSource = null;
            lstTierarten.DataSource = tierartRepo.GetAll();
            lstTierarten.DisplayMember = "TABezeichnung";

            cboTierart.DataSource = null;
            cboTierart.DataSource = tierartRepo.GetAll();
            cboTierart.DisplayMember = "TABezeichnung";
            cboTierart.ValueMember = "TierartID";
        }

        private void lstTierarten_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTierart = lstTierarten.SelectedItem as Tierart;
            if (selectedTierart == null) return;
            txtTierartBez.Text = selectedTierart.TABezeichnung;
        }

        private void btnTierartSpeichern_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTierartBez.Text)) return;

            if (selectedTierart == null)
            {
                tierartRepo.Insert(new Tierart { TABezeichnung = txtTierartBez.Text });
            }
            else
            {
                selectedTierart.TABezeichnung = txtTierartBez.Text;
                tierartRepo.Update(selectedTierart);
            }

            selectedTierart = null;
            txtTierartBez.Clear();
            LoadTierarten();
            LoadTiere();
            LoadUebersicht();
        }

        private void btnTierartLoeschen_Click(object sender, EventArgs e)
        {
            if (selectedTierart == null) return;
            tierartRepo.Delete(selectedTierart.TierartID);
            selectedTierart = null;
            txtTierartBez.Clear();
            LoadTierarten();
            LoadTiere();
            LoadUebersicht();
        }

        // ===== Tiere =====
        private void LoadTiere()
        {
            lstTiere.DataSource = null;
            lstTiere.DataSource = tierRepo.GetAll();
            lstTiere.DisplayMember = "Name";

            cboTierart.DataSource = tierartRepo.GetAll();
            cboTierart.DisplayMember = "TABezeichnung";
            cboTierart.ValueMember = "TierartID";

            cboTierGehege.DataSource = gehegeRepo.GetAll();
            cboTierGehege.DisplayMember = "GBezeichnung";
            cboTierGehege.ValueMember = "gID";

            LoadRationCombos();
        }

        private void lstTiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedTier = lstTiere.SelectedItem as Tier;
            if (selectedTier == null) return;

            txtTierName.Text = selectedTier.Name;
            txtTierGewicht.Text = selectedTier.Gewicht.ToString("0.###");
            dtpTierGeburt.Value = selectedTier.Geburtsdatum;
            cboTierart.SelectedValue = selectedTier.TierartID;
            cboTierGehege.SelectedValue = selectedTier.GehegeID;
        }

        private void btnTierSpeichern_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTierName.Text)) return;
            if (!double.TryParse(txtTierGewicht.Text, out var gewicht)) return;
            if (cboTierart.SelectedValue == null || cboTierGehege.SelectedValue == null) return;

            if (selectedTier == null)
            {
                tierRepo.Insert(new Tier
                {
                    Name = txtTierName.Text,
                    Gewicht = gewicht,
                    Geburtsdatum = dtpTierGeburt.Value.Date,
                    TierartID = (int)cboTierart.SelectedValue,
                    GehegeID = (int)cboTierGehege.SelectedValue
                });
            }
            else
            {
                selectedTier.Name = txtTierName.Text;
                selectedTier.Gewicht = gewicht;
                selectedTier.Geburtsdatum = dtpTierGeburt.Value.Date;
                selectedTier.TierartID = (int)cboTierart.SelectedValue;
                selectedTier.GehegeID = (int)cboTierGehege.SelectedValue;
                tierRepo.Update(selectedTier);
            }

            selectedTier = null;
            txtTierName.Clear();
            txtTierGewicht.Clear();
            LoadTiere();
            LoadUebersicht();
            LoadRationCombos();
        }

        private void btnTierLoeschen_Click(object sender, EventArgs e)
        {
            if (selectedTier == null) return;
            tierRepo.Delete(selectedTier.TierID);
            selectedTier = null;
            txtTierName.Clear();
            txtTierGewicht.Clear();
            LoadTiere();
            LoadUebersicht();
            LoadRationCombos();
        }

        // ===== Futter =====
        private void LoadFutter()
        {
            lstFutter.DataSource = null;
            lstFutter.DataSource = futterRepo.GetAll();
            lstFutter.DisplayMember = "Bezeichnung";

            cboRationFutter.DataSource = null;
            cboRationFutter.DataSource = futterRepo.GetAll();
            cboRationFutter.DisplayMember = "Bezeichnung";
            cboRationFutter.ValueMember = "FutterID";
        }

        private void lstFutter_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFutter = lstFutter.SelectedItem as Futter;
            if (selectedFutter == null) return;
            txtFutterBez.Text = selectedFutter.Bezeichnung;
            txtFutterVerpackung.Text = selectedFutter.Verpackungsgroesse;
            txtFutterKommentar.Text = selectedFutter.Kommentar;
        }

        private void btnFutterSpeichern_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFutterBez.Text)) return;

            if (selectedFutter == null)
            {
                futterRepo.Insert(new Futter
                {
                    Bezeichnung = txtFutterBez.Text,
                    Verpackungsgroesse = txtFutterVerpackung.Text,
                    Kommentar = txtFutterKommentar.Text
                });
            }
            else
            {
                selectedFutter.Bezeichnung = txtFutterBez.Text;
                selectedFutter.Verpackungsgroesse = txtFutterVerpackung.Text;
                selectedFutter.Kommentar = txtFutterKommentar.Text;
                futterRepo.Update(selectedFutter);
            }

            selectedFutter = null;
            txtFutterBez.Clear();
            txtFutterVerpackung.Clear();
            txtFutterKommentar.Clear();
            LoadFutter();
            LoadRationCombos();
        }

        private void btnFutterLoeschen_Click(object sender, EventArgs e)
        {
            if (selectedFutter == null) return;
            futterRepo.Delete(selectedFutter.FutterID);
            selectedFutter = null;
            txtFutterBez.Clear();
            txtFutterVerpackung.Clear();
            txtFutterKommentar.Clear();
            LoadFutter();
            LoadRationCombos();
        }

        // ===== Futterrationen =====
        private void LoadRationCombos()
        {
            cboRationTier.DataSource = null;
            cboRationTier.DataSource = tierRepo.GetAll();
            cboRationTier.DisplayMember = "Name";
            cboRationTier.ValueMember = "TierID";

            cboRationFutter.DataSource = null;
            cboRationFutter.DataSource = futterRepo.GetAll();
            cboRationFutter.DisplayMember = "Bezeichnung";
            cboRationFutter.ValueMember = "FutterID";

            LoadRationen();
        }

        private void cboRationTier_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRationen();
        }

        private void LoadRationen()
        {
            if (cboRationTier.SelectedValue == null) return;
            int tid = (int)cboRationTier.SelectedValue;
            var list = futterrationRepo.GetByTier(tid);
            lstRationen.DataSource = null;
            lstRationen.DataSource = list;
            lstRationen.DisplayMember = "Anzeige";
        }

        private void btnRationSpeichern_Click(object sender, EventArgs e)
        {
            if (cboRationTier.SelectedValue == null || cboRationFutter.SelectedValue == null) return;
            if (string.IsNullOrWhiteSpace(txtRationMenge.Text)) return;

            var r = new Futterration
            {
                TierID = (int)cboRationTier.SelectedValue,
                FutterID = (int)cboRationFutter.SelectedValue,
                Menge = txtRationMenge.Text,
                Uhrzeit = dtpRationUhrzeit.Value.TimeOfDay
            };

            futterrationRepo.Insert(r);
            txtRationMenge.Clear();
            LoadRationen();
        }

        private void btnRationLoeschen_Click(object sender, EventArgs e)
        {
            if (lstRationen.SelectedItem is Futterration r)
            {
                futterrationRepo.Delete(r.RationID);
                LoadRationen();
            }
        }

        // ===== Übersicht =====
        private void LoadUebersicht()
        {
            dgvUebersicht.DataSource = tierRepo.GetOverview();
        }
    }
}
