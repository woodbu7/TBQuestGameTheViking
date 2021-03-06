﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TB_QuestGame
{
    /// <summary>
    /// the character class the player uses in the game
    /// </summary>
    public class Player : Character
    {
        #region ENUMERABLES

        public enum VikingType
        {
            None,
            Karl,
            Shieldmaiden
        }

        #endregion

        #region FIELDS

        private VikingType _viking;
        private string _homeVillage;
        private int _capital;
        private bool _isArmed;
        private bool _isShielded;
        private int _health;
        private int _lives;
        private int _experiencePoints;
        private int _energy;
        private List<int> _locationsVisited;
        private List<GameObject> _inventory;
        private List<int> _talkedToNPCs;
        private int _currentLevel;
        private Weapon _primaryWeapon;
        private Weapon _primaryShield;
        private int _inventoryWeight;
        private List<int> _hasPickedUp;

        #endregion

        #region PROPERTIES

        public VikingType Viking
        {
            get { return _viking; }
            set { _viking = value; }
        }

        public string HomeVillage
        {
            get { return _homeVillage; }
            set { _homeVillage = value; }
        }

        public int Capital
        {
            get { return _capital; }
            set { _capital = value; }
        }

        public bool IsArmed
        {
            get { return _isArmed; }
            set { _isArmed = value; }
        }

        public bool IsShielded
        {
            get { return _isShielded; }
            set { _isShielded = value; }
        }

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int Lives
        {
            get { return _lives; }
            set { _lives = value; }
        }

        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            set { _experiencePoints = value; }
        }

        public int Energy
        {
            get { return _energy; }
            set { _energy = value; }
        }

        public List<int> LocationsVisted
        {
            get { return _locationsVisited; }
            set { _locationsVisited = value; }
        }

        public List<int> TalkedToNPCs
        {
            get { return _talkedToNPCs; }
            set { _talkedToNPCs = value; }
        }

        public List<GameObject> Inventory
        {
            get { return _inventory; }
            set { _inventory = value; }
        }

        public int CurrentLevel
        {
            get { return _currentLevel; }
            set { _currentLevel = value; }
        }

        public Weapon PrimaryWeapon
        {
            get { return _primaryWeapon; }
            set { _primaryWeapon = value; }
        }

        public Weapon PrimaryShield
        {
            get { return _primaryShield; }
            set { _primaryShield = value; }
        }

        public int InventoryWeight
        {
            get { return _inventoryWeight; }
            set { _inventoryWeight = value; }
        }

        public List<int> HasPickedUp
        {
            get { return _hasPickedUp; }
            set { _hasPickedUp = value; }
        }
        #endregion

        #region CONSTRUCTORS

        public Player()
        {
            _locationsVisited = new List<int>();
            _talkedToNPCs = new List<int>();
            _hasPickedUp = new List<int>();
            _inventory = new List<GameObject>();
        }

        public Player(string name, int locationId) : base(name, locationId)
        {
            _locationsVisited = new List<int>();
            _inventory = new List<GameObject>();
        }

        #endregion

        #region METHODS

        /// <summary>
        /// Return true/false if location is in the visited locations list
        /// </summary>
        /// <param name="_locationId"></param>
        /// <returns></returns>
        public bool HasVisited(int _locationId)
        {
            if (LocationsVisted.Contains(_locationId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Return true/false if the Npc is in the TalkedToNpc list
        /// </summary>
        /// <param name="_npcId"></param>
        /// <returns></returns>
        public bool HasTalkedTo(int _npcId)
        {
            if (TalkedToNPCs.Contains(_npcId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// return true if object will increase inventory max weight if added
        /// </summary>
        /// <param name="objectWeight"></param>
        /// <returns></returns>
        public bool MaxWeight(int objectWeight)
        {
            if (this.InventoryWeight + objectWeight > 50)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
