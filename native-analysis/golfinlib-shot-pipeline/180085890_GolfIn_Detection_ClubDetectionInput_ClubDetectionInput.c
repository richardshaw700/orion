FUNCTION: GolfIn::Detection::ClubDetectionInput::~ClubDetectionInput
ENTRY: 180085890
REASONS: name:club


/* public: __cdecl GolfIn::Detection::ClubDetectionInput::~ClubDetectionInput(void) __ptr64 */

void __thiscall GolfIn::Detection::ClubDetectionInput::~ClubDetectionInput(ClubDetectionInput *this)

{
                    /* 0x85890  85  ??1ClubDetectionInput@Detection@GolfIn@@QEAA@XZ */
  cv::Mat::~Mat((Mat *)(this + 0x88));
  cv::Mat::~Mat((Mat *)(this + 0x28));
  FUN_18000c8d0((longlong *)this);
  return;
}

