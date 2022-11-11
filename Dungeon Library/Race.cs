using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Library
{
    public enum Race
    {
        Elf,
        Human,
        Merfolk,
        Troll,
        Gnome,
        Demon
    }
        //8. Update the Weapon class to use the WeaponType enum

        //a. Add a field/property for Type with is of data type WeaponType

        //b.Add Type to the FQCTOR

        //c.Add Type to the ToString()
    public enum WeaponType
    {
        Sword,
        Knife,
        Axe,
        Bow,
        Lightsaber
    }
}
