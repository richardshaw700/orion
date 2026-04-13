FUNCTION: GolfIn::Interface::resetWaitForShot
ENTRY: 1800ddab0
REASONS: name:waitForShot


/* public: void __cdecl GolfIn::Interface::resetWaitForShot(void) __ptr64 */

void __thiscall GolfIn::Interface::resetWaitForShot(Interface *this)

{
                    /* 0xddab0  905  ?resetWaitForShot@Interface@GolfIn@@QEAAXXZ */
  LOCK();
  this[0x28a] = (Interface)0x1;
  UNLOCK();
  LOCK();
  this[0x28b] = (Interface)0x0;
  UNLOCK();
  LOCK();
  this[0x28c] = (Interface)0x0;
  UNLOCK();
  return;
}

