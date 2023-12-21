﻿namespace Bytecode
{
    public enum InstructionTypes
    { 
        INST_SET_HEALTH = 0x00,
        INST_SET_WISDOM = 0x01,
        INST_SET_AGILITY = 0x02,
        INST_PLAY_SOUND = 0x03,
        INST_SPAWN_PARTUCLES = 0x04,
        INST_LITERAL = 0x05,
        INST_GET_HEALTH = 0x06,
        INST_GET_WISDOM = 0x07,
        INST_GET_AGILITY = 0x09,
        INST_ADD = 0x10,
        INST_DIVIDE = 0x11
    }
}
