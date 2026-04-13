FUNCTION: GolfIn::Detection::ClubDetection::extractClubCentroid
ENTRY: 180089010
REASONS: name:club


/* protected: virtual void __cdecl GolfIn::Detection::ClubDetection::extractClubCentroid(void)
   __ptr64 */

void __thiscall GolfIn::Detection::ClubDetection::extractClubCentroid(ClubDetection *this)

{
  undefined8 local_28;
  undefined8 uStack_20;
  undefined8 local_18;
  
                    /* 0x89010  565  ?extractClubCentroid@ClubDetection@Detection@GolfIn@@MEAAXXZ */
  local_18 = 0;
  local_28 = 0;
  uStack_20 = 0;
  Libraries::Core::extract_biggest_blob(this + 8,this + 8,&local_28,0xffffffffffffffff);
  *(float *)(this + 0x68) = (float)local_18 + *(float *)(this + 0x70);
  *(float *)(this + 0x6c) = local_18._4_4_ + *(float *)(this + 0x74);
  return;
}

