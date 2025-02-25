﻿namespace DVMultiplayer.Networking
{
    public enum NetworkTags : ushort
    {
        TEST_TAG,
        PLAYER_SPAWN,
        PLAYER_LOCATION_UPDATE,
        PLAYER_DISCONNECT,
        PLAYER_WORLDMOVED,
        PLAYER_MODS_MISMATCH,
        PLAYER_SPAWN_SET,
        PLAYER_INIT,
        PLAYER_LOADED,
        PLAYER_SET_ROLE, // Set Player Role (Host or Client)
        TRAIN_LEVER,
        TRAIN_SWITCH,
        TRAIN_LOCATION_UPDATE,
        TRAIN_DERAIL,
        TRAIN_COUPLE,
        TRAIN_COUPLE_HOSE,
        TRAIN_COUPLE_COCK,
        TRAIN_UNCOUPLE,
        TRAIN_SYNC,
        TRAIN_SYNC_ALL,
        TRAIN_RERAIL,
        TRAINS_INIT,
        TRAIN_REMOVAL,
        TRAIN_HOST_SYNC,
        TRAIN_DAMAGE,
        TRAINS_INIT_FINISHED,
        TRAIN_AUTH_CHANGE,
        TRAIN_CARGO_CHANGE,
        SWITCH_CHANGED,
        SWITCH_SYNC,
        SWITCH_HOST_SYNC,
        TURNTABLE_ANGLE_CHANGED,
        TURNTABLE_SYNC,
        TURNTABLE_SNAP,
        TURNTABLE_AUTH_RELEASE,
        TURNTABLE_AUTH_REQUEST,
        TURNTABLE_HOST_SYNC,
        JOB_CREATED,
        JOB_SYNC,
        JOB_HOST_SYNC,
        JOB_TAKEN,
        JOB_COMPLETED,
        JOB_NEXT_JOB,
        JOB_CHAIN_COMPLETED,
        JOB_CHAIN_CHANGED,
        PING,
        DEBT_LOCO_PAID,
        JOB_CHAIN_EXPIRED,
        JOB_STATION_EXPIRATION,
        TRAIN_MU_CHANGE,
        DEBT_JOB_PAID,
        DEBT_OTHER_PAID,
    }
}
