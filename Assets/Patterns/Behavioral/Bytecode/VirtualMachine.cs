using System.Collections.Generic;
using Zenject;

namespace Bytecode
{
    public class VirtualMachine : IInitializable
    {
        private Stack<int> _stack = new Stack<int>();

        private MagicalAPI _api;

        public VirtualMachine(MagicalAPI api)
            => _api = api;

        public void Initialize()
        {
            char[] bytecode = new char[]
            { 
                (char)InstructionTypes.INST_LITERAL, (char)0,
                (char)InstructionTypes.INST_LITERAL, (char)0,
                (char)InstructionTypes.INST_GET_HEALTH,
                (char)InstructionTypes.INST_LITERAL, (char)0,
                (char)InstructionTypes.INST_GET_AGILITY,
                (char)InstructionTypes.INST_LITERAL, (char)0,
                (char)InstructionTypes.INST_GET_WISDOM,
                (char)InstructionTypes.INST_ADD,
                (char)InstructionTypes.INST_LITERAL, (char)2,
                (char)InstructionTypes.INST_DIVIDE,
                (char)InstructionTypes.INST_ADD,
                (char)InstructionTypes.INST_SET_HEALTH
            };

            Interpret(bytecode);
        }

        public void Interpret(char[] bytecode)
        {          
            for (int i = 0; i < bytecode.Length; i++)
            {
                char instruction = bytecode[i];

                int value;

                int amount;
                int wizard;

                int a;
                int b;

                switch (instruction)
                {
                    case (char)InstructionTypes.INST_SET_HEALTH:
                        amount = _stack.Pop();
                        wizard = _stack.Pop();
                        _api.SetHealth(wizard, amount);
                        break;

                    case (char)InstructionTypes.INST_SET_WISDOM:
                        amount = _stack.Pop();
                        wizard = _stack.Pop();
                        _api.SetWisdom(wizard, amount);
                        break;

                    case (char)InstructionTypes.INST_SET_AGILITY:
                        amount = _stack.Pop();
                        wizard = _stack.Pop();
                        _api.SetAgility(wizard, amount);
                        break;

                    case (char)InstructionTypes.INST_PLAY_SOUND:
                        _api.PlaySound(_stack.Pop());
                        break;

                    case (char)InstructionTypes.INST_SPAWN_PARTUCLES:
                        _api.SpawnParticles(_stack.Pop());
                        break;

                    case (char)InstructionTypes.INST_LITERAL:
                        value = bytecode[++i];
                        _stack.Push(value);
                        break;

                    case (char)InstructionTypes.INST_GET_HEALTH:
                        wizard = _stack.Pop();
                        _stack.Push(_api.GetHealth(wizard));
                        break;

                    case (char)InstructionTypes.INST_GET_WISDOM:
                        wizard = _stack.Pop();
                        _stack.Push(_api.GetWisdom(wizard));
                        break;

                    case (char)InstructionTypes.INST_GET_AGILITY:
                        wizard = _stack.Pop();
                        _stack.Push(_api.GetAgility(wizard));
                        break;

                    case (char)InstructionTypes.INST_ADD:
                        b = _stack.Pop();
                        a = _stack.Pop();
                        _stack.Push(a + b);
                        break;

                    case (char)InstructionTypes.INST_DIVIDE:
                        b = _stack.Pop();
                        a = _stack.Pop();
                        _stack.Push(a / b);
                        break;
                }
            }
        }
    }
}

