using System;
using UnityEngine;
using System.Collections.Generic;
using Zenject;

namespace Flyweight
{
    public class TechnicalService : IDisposable, IInitializable
    {
        private InputHandler _input;

        private TechnicalFactory _factory;

        private Technica _car;
        private Technica _bike;
        private Technica _plane;

        private Queue<Technica> _technicas;

        public TechnicalService(InputHandler input, TechnicalFactory technicalFactroy) 
        { 
            _input = input;

            _input.SpaceClicked += ToServe;

            _factory = technicalFactroy;

            _car = _factory.GetCar();
            _bike = _factory.GetBike();
            _plane = _factory.GetPlane();

            _technicas = new Queue<Technica>();
        }

        public void Initialize()
            => GenerateQueue();

        public void Dispose()
            => _input.SpaceClicked -= ToServe;

        private void GenerateQueue()
        {
            if(_technicas.Count > 0)
                _technicas.Clear();

            int queue = 10;

            while (queue > 0)
            {
                int random = UnityEngine.Random.Range(0, 3);

                switch (random)
                {
                    case 0:
                        _technicas.Enqueue(_car);
                        break;

                    case 1:
                        _technicas.Enqueue(_bike);
                        break;

                    case 2:
                        _technicas.Enqueue(_plane);
                        break;

                    default:
                        throw new ArgumentOutOfRangeException(nameof(random));
                }
                 
                queue--;
            }
        } 

        private void ToServe()
        {
            if (_technicas.Count == 0)
            {
                Debug.Log("No technical");
                return;
            }

            Technica currentTechnica = _technicas.Dequeue();

            Debug.Log($"Technica info: {currentTechnica.Name} \t Seats count: {currentTechnica.SeatsCount} \t Speed: {currentTechnica.Speed}");
        }
    }
}
