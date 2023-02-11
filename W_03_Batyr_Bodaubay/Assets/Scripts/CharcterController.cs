using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharcterController : MonoBehaviour
{
    // Start is called before the first frame update
    InputSystem _ipS;
    CharacterController _charCntrl;
    Animator _anim;

    Vector2 MovementInput;
    Vector3 MovementVal;
    bool isMovementTriggered;
    bool isRunning;
    float speed;
    private float targetIncrease=0;
    private float gravity;
    private bool CrouchPressed;
    private bool JumpPressed;
    private bool InjurePressed;
    private bool ReadyPressed;
    private float dmg=0.01f;
    
    private float percentHP=0f;
    private bool isAttack;
    private float targetChange=0f;

    void Awake()
    {
        
        _ipS = new InputSystem();
        _charCntrl = GetComponent<CharacterController>();
        _anim = GetComponent<Animator>();

        _ipS.CharcterMovementControls.Movement1.started += MoveCntx; 
        _ipS.CharcterMovementControls.Movement1.performed += MoveCntx;
        _ipS.CharcterMovementControls.Movement1.canceled += MoveCntx;

        _ipS.CharcterMovementControls.Running.started += context =>{
            isRunning = context.ReadValueAsButton();
        };
        _ipS.CharcterMovementControls.Running.canceled += context =>{
            isRunning = context.ReadValueAsButton();
        };

        _ipS.CharcterMovementControls.Crouching.started += context =>{
            CrouchPressed = context.ReadValueAsButton();
        };
        _ipS.CharcterMovementControls.Crouching.canceled += context =>{
            CrouchPressed = context.ReadValueAsButton();
        };

        _ipS.CharcterMovementControls.Jumping.started += context =>{
            JumpPressed = context.ReadValueAsButton();
        };
        _ipS.CharcterMovementControls.Jumping.canceled += context =>{
            JumpPressed = context.ReadValueAsButton();
        };

        _ipS.CharcterMovementControls.Injure.started += context =>{
            InjurePressed = context.ReadValueAsButton();
        };
        _ipS.CharcterMovementControls.Injure.canceled += context =>{
            InjurePressed = context.ReadValueAsButton();
        };

        _ipS.CharcterMovementControls.Ready.started += context =>{
            ReadyPressed = context.ReadValueAsButton();
        };
        _ipS.CharcterMovementControls.Ready.canceled += context =>{
            ReadyPressed = context.ReadValueAsButton();
        };

        _ipS.CharcterMovementControls.Attack.started += context =>{
            isAttack = context.ReadValueAsButton();
        };
        _ipS.CharcterMovementControls.Attack.canceled += context =>{
            isAttack = context.ReadValueAsButton();
        };
       
    }
        
    void MoveCntx(InputAction.CallbackContext context){
        MovementInput = context.ReadValue<Vector2>();
        MovementVal.x = MovementInput.x;
        MovementVal.z = MovementInput.y;
        isMovementTriggered = MovementInput.x != 0 || MovementInput.y != 0;
    }

    
    void AnimationUpdate()
    {
        speed = _anim.GetFloat("Speed");
       
        if(isMovementTriggered){
            if(!isRunning&&!CrouchPressed){
                if(speed<0.33f){
                    targetIncrease+=0.02f;
                }else if(speed>0.34f){
                    targetIncrease-=0.01f;
                }
            }else{
                targetIncrease +=0.02f; 
                if(targetIncrease > 1f) targetIncrease = 1f;
            }
            _anim.SetFloat("Speed",targetIncrease);
        }else if(!isMovementTriggered && speed >0){
            targetIncrease -= 0.01f;
            if(targetIncrease <0) targetIncrease = 0;
            _anim.SetFloat("Speed", targetIncrease);
        }

        if(CrouchPressed){
            _anim.SetBool("isCrouch", true);
        }else if(!CrouchPressed){
            _anim.SetBool("isCrouch", false);
        }

        if(!CrouchPressed && JumpPressed){
            _anim.SetBool("isJump",true);
        }

        if(ReadyPressed){
            targetChange += 0.05f;
            if(targetChange>1) targetChange = 1; 
             _anim.SetLayerWeight(2,targetChange);
             if(isAttack){
                _anim.SetTrigger("isAttack");
             }else{
                _anim.ResetTrigger("isAttack");
             }
        }else{
            targetChange -= 0.05f;
            if(targetChange<0) targetChange = 0; 
            _anim.SetLayerWeight(2,targetChange);
        }
    }
    
    void JumpEnd(){
         _anim.SetBool("isJump",false);
    }
    void RotationUpdate(){
        Vector3 targetPos;
        targetPos.x = MovementVal.x;
        targetPos.y = 0;
        targetPos.z = MovementVal.z;

        Quaternion currRotation = transform.rotation;
        if(isMovementTriggered){
            Quaternion targRotation = Quaternion.LookRotation(targetPos);
            transform.rotation = Quaternion.Slerp(currRotation, targRotation, 6f*Time.deltaTime);
        }
    }
    void GravityUpdate(){
        if(_anim.GetBool("isJump")){
            return;
        }else{
            if(!_charCntrl.isGrounded){
            gravity = -9.81f*Time.deltaTime;
            MovementVal.y += gravity;
            }else{
            gravity = -0.5f;
            MovementVal.y = gravity;
            }
        }
        
        _charCntrl.Move(new Vector3(0,MovementVal.y*Time.deltaTime,0));
    }

    void HealthUpdate(){
        if(InjurePressed){
            percentHP+=dmg; 
            if(percentHP>1) percentHP=1;
        }else{
            percentHP-=0.02f;
            if(percentHP<0) percentHP=0;
        }
        _anim.SetLayerWeight(1,percentHP);
    }
    // Update is called once per frame
    void Update()
    {
        HealthUpdate();
        GravityUpdate();
        RotationUpdate();
        AnimationUpdate();
    }
    void OnEnable()
    {
        _ipS.CharcterMovementControls.Enable();
    }
}
