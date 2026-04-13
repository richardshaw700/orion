FUNCTION: GolfIn::YoloClubSegmentation::~YoloClubSegmentation
ENTRY: 180085490
REASONS: name:club


/* public: __cdecl GolfIn::YoloClubSegmentation::~YoloClubSegmentation(void) __ptr64 */

void __thiscall GolfIn::YoloClubSegmentation::~YoloClubSegmentation(YoloClubSegmentation *this)

{
  Net *this_00;
  
                    /* 0x85490  100  ??1YoloClubSegmentation@GolfIn@@QEAA@XZ */
  FUN_18000c8d0((longlong *)(this + 0x118));
  FUN_18000c8d0((longlong *)(this + 0xf8));
  FUN_18000c8d0((longlong *)(this + 0xc0));
  _Mtx_destroy_in_situ(this + 0x50);
  this_00 = *(Net **)(this + 0x48);
  if (this_00 != (Net *)0x0) {
    cv::dnn::dnn4_v20240521::Net::~Net(this_00);
    free(this_00);
  }
  FUN_18000c8d0((longlong *)(this + 0x28));
  FUN_18000c8d0((longlong *)(this + 8));
  return;
}

