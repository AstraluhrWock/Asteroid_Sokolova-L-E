using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System;

namespace Asteroids.ParsingFromFile
{
    public class MainUnitParsing : MonoBehaviour
    {
        private void Start()
        {
            TextAsset textFile = Resources.Load<TextAsset>("UnitData/UnitData2");
            UnitArray unitsArray = JsonUtility.FromJson<UnitArray>(textFile.text);

            UnitFactory unitFactory = new UnitFactory();
            List<Unit> units = new List<Unit>();

            foreach (var unitData in unitsArray.allUnits)
            {
                Unit unit = unitFactory.CreateUnit(unitData);
                if (unit != null)
                {
                    units.Add(unit);
                    Debug.Log("Type: " + unit.type);
                    Debug.Log("Health: " + unit.health);
                }
            }
        }
    }
}
