FUNCTION: GolfIn::Detection::ClubDetection::getClubBounding
ENTRY: 180086460
REASONS: name:club


/* public: class cv::Rect_<float> __cdecl
   GolfIn::Detection::ClubDetection::getClubBounding(void)const __ptr64 */

void __thiscall GolfIn::Detection::ClubDetection::getClubBounding(ClubDetection *this)

{
  undefined8 uVar1;
  undefined8 *in_RDX;
  
                    /* 0x86460  636
                       ?getClubBounding@ClubDetection@Detection@GolfIn@@QEBA?AV?$Rect_@M@cv@@XZ */
  uVar1 = *(undefined8 *)(this + 0x78);
  *in_RDX = *(undefined8 *)(this + 0x70);
  in_RDX[1] = uVar1;
  return;
}

