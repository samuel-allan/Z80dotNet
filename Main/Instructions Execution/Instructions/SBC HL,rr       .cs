﻿// AUTOGENERATED CODE
//
// Do not make changes directly to this (.cs) file.
// Change "SBC HL,rr       .tt" instead.

namespace Konamiman.Z80dotNet
{
    public partial class Z80InstructionExecutor
    {
        /// <summary>
        /// The SBC HL,BC instruction
        /// </summary>
        byte SBC_HL_BC()
        {
            FetchFinished();

            var previousHighByte = Registers.H;
            var oldValue = Registers.HL;
            var valueToSub = Registers.BC;
            var newValue = oldValue.Sub(valueToSub).Sub((short)Registers.CF);
            Registers.HL = newValue;
            var newHighByte = Registers.H;

            Registers.SF = newHighByte.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newHighByte & 0x0F) > (previousHighByte & 0x0F);
            Registers.CF = (previousHighByte.GetBit(7) == 0) && (newHighByte.GetBit(7) == 1);
            var valueToAddMSB = valueToSub.GetHighByte().GetBit(7);
            var oldValueMSB = previousHighByte.GetBit(7);
            var newValueMSB = newHighByte.GetBit(7);
            Registers.PF = (oldValueMSB != valueToAddMSB) && (valueToAddMSB == newValueMSB);

            Registers.NF = 1;
            SetFlags3and5From(newValue.GetHighByte());

            return 15;
        }

        /// <summary>
        /// The SBC HL,DE instruction
        /// </summary>
        byte SBC_HL_DE()
        {
            FetchFinished();

            var previousHighByte = Registers.H;
            var oldValue = Registers.HL;
            var valueToSub = Registers.DE;
            var newValue = oldValue.Sub(valueToSub).Sub((short)Registers.CF);
            Registers.HL = newValue;
            var newHighByte = Registers.H;

            Registers.SF = newHighByte.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newHighByte & 0x0F) > (previousHighByte & 0x0F);
            Registers.CF = (previousHighByte.GetBit(7) == 0) && (newHighByte.GetBit(7) == 1);
            var valueToAddMSB = valueToSub.GetHighByte().GetBit(7);
            var oldValueMSB = previousHighByte.GetBit(7);
            var newValueMSB = newHighByte.GetBit(7);
            Registers.PF = (oldValueMSB != valueToAddMSB) && (valueToAddMSB == newValueMSB);

            Registers.NF = 1;
            SetFlags3and5From(newValue.GetHighByte());

            return 15;
        }

        /// <summary>
        /// The SBC HL,HL instruction
        /// </summary>
        byte SBC_HL_HL()
        {
            FetchFinished();

            var previousHighByte = Registers.H;
            var oldValue = Registers.HL;
            var valueToSub = Registers.HL;
            var newValue = oldValue.Sub(valueToSub).Sub((short)Registers.CF);
            Registers.HL = newValue;
            var newHighByte = Registers.H;

            Registers.SF = newHighByte.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newHighByte & 0x0F) > (previousHighByte & 0x0F);
            Registers.CF = (previousHighByte.GetBit(7) == 0) && (newHighByte.GetBit(7) == 1);
            var valueToAddMSB = valueToSub.GetHighByte().GetBit(7);
            var oldValueMSB = previousHighByte.GetBit(7);
            var newValueMSB = newHighByte.GetBit(7);
            Registers.PF = (oldValueMSB != valueToAddMSB) && (valueToAddMSB == newValueMSB);

            Registers.NF = 1;
            SetFlags3and5From(newValue.GetHighByte());

            return 15;
        }

        /// <summary>
        /// The SBC HL,SP instruction
        /// </summary>
        byte SBC_HL_SP()
        {
            FetchFinished();

            var previousHighByte = Registers.H;
            var oldValue = Registers.HL;
            var valueToSub = Registers.SP;
            var newValue = oldValue.Sub(valueToSub).Sub((short)Registers.CF);
            Registers.HL = newValue;
            var newHighByte = Registers.H;

            Registers.SF = newHighByte.GetBit(7);
            Registers.ZF = (newValue == 0);
            Registers.HF = (newHighByte & 0x0F) > (previousHighByte & 0x0F);
            Registers.CF = (previousHighByte.GetBit(7) == 0) && (newHighByte.GetBit(7) == 1);
            var valueToAddMSB = valueToSub.GetHighByte().GetBit(7);
            var oldValueMSB = previousHighByte.GetBit(7);
            var newValueMSB = newHighByte.GetBit(7);
            Registers.PF = (oldValueMSB != valueToAddMSB) && (valueToAddMSB == newValueMSB);

            Registers.NF = 1;
            SetFlags3and5From(newValue.GetHighByte());

            return 15;
        }

    }
}
