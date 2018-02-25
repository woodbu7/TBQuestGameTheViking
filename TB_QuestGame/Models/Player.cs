﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public enum Weapon
        {
            None,
            Sword,
            Axe,
            Shield,
            Bow, 
            Knife
        }

        #endregion

        #region FIELDS

        private VikingType _viking;
        private string _homeVillage;
        private int _capital;
        private List<Weapon> _weaponType;
        private bool _isArmed;

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

        public List<Weapon> WeaponType
        {
            get { return _weaponType; }
            set { _weaponType = value; }
        }

        public bool IsArmed
        {
            get { return _isArmed; }
            set { _isArmed = value; }
        }

        #endregion

        #region CONSTRUCTORS

        public Player()
        {

        }

        public Player(string name, CharacterType race, string homeVillage, bool isFriendly) : base(name, race, isFriendly)
        {

        }

        #endregion

        #region METHODS

        public override string Greeting()
        {
            return $"Hello! I am {base.Name} of {_homeVillage}.";
        }

        #endregion
    }
}
