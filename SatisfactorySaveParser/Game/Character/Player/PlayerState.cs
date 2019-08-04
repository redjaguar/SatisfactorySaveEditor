﻿using System.Collections.Generic;
using System.IO;

using SatisfactorySaveParser.Game.Enums;
using SatisfactorySaveParser.Game.Structs;
using SatisfactorySaveParser.Save;

namespace SatisfactorySaveParser.Game.Character.Player
{
    [SaveObjectClass("/Game/FactoryGame/Character/Player/BP_PlayerState.BP_PlayerState_C")]
    public class PlayerState : SaveActor
    {
        [SaveProperty("mHotbarShortcuts")]
        public List<ObjectReference> HotbarShortcuts { get; } = new List<ObjectReference>();

        [SaveProperty("mNewRecipes")]
        public List<ObjectReference> NewRecipes { get; } = new List<ObjectReference>();

        [SaveProperty("mOwnedPawn")]
        public ObjectReference OwnedPawn { get; set; }

        [SaveProperty("mHasReceivedInitialItems")]
        public bool HasReceivedInitialItems { get; set; }

        [SaveProperty("mHasSetupDefaultShortcuts")]
        public bool HasSetupDefaultShortcuts { get; set; }

        [SaveProperty("mTutorialSubsystem")]
        public ObjectReference TutorialSubsystem { get; set; }

        [SaveProperty("mMessageData")]
        public List<FMessageData> MessageData { get; } = new List<FMessageData>();

        [SaveProperty("mRememberedFirstTimeEquipmentClasses")]
        public List<ObjectReference> RememberedFirstTimeEquipmentClasses { get; } = new List<ObjectReference>();

        [SaveProperty("mNumArmSlots")]
        public int NumArmSlots { get; set; }

        [SaveProperty("mOnlyShowAffordableRecipes")]
        public bool OnlyShowAffordableRecipes { get; set; }

        [SaveProperty("mCollapsedItemCategories")]
        public List<ObjectReference> CollapsedItemCategories { get; } = new List<ObjectReference>();

        [SaveProperty("mFilteredOutMapTypes")]
        public List<ERepresentationType> FilteredOutMapTypes { get; } = new List<ERepresentationType>();

        [SaveProperty("mFilteredOutCompassTypes")]
        public List<ERepresentationType> FilteredOutCompassTypes { get; } = new List<ERepresentationType>();

        public byte[] UserID { get; private set; } = new byte[18];

        public override void DeserializeNativeData(BinaryReader reader, int length)
        {
            UserID = reader.ReadBytes(18);
        }
    }
}