using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmployeeManager : MonoBehaviour
{

    [SerializeField] float movementHorizontal;
    [SerializeField] float movementVertical;

    [SerializeField] float cameraMoveTime = 1f;

    [SerializeField] List<Employee> employees;

    private Employee currentEmployee;
    private Employee nextEmployee;

    private int currentEmployeeIndex = 0;

    private float startTime;

    private bool switchingEmployees = false;

    private bool lockInput = false;

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
        currentEmployee = employees[currentEmployeeIndex];
    }

    void Update()
    {
        MoveCameraToNextEmployee();
        mainCamera.transform.position = new Vector3(transform.position.x, transform.position.y, mainCamera.transform.position.z);


        if (lockInput) return;
        this.transform.position = currentEmployee.transform.position;
        movementHorizontal = Input.GetAxis("Horizontal");
        movementVertical = Input.GetAxis("Vertical");
        if (Input.GetButtonDown("Switch Employee"))
        {
            startTime = Time.time;
            currentEmployeeIndex = currentEmployeeIndex + 1 >= employees.Count ? 0 : currentEmployeeIndex + 1;
            nextEmployee = employees[currentEmployeeIndex];
            movementHorizontal = 0f;
            movementVertical = 0f;
            LockInputAndTurnOnBool(out switchingEmployees);
        }
    }

    private void MoveCameraToNextEmployee()
    {
        if (!switchingEmployees) return;
        float elapsedTime = Time.time - startTime;
        this.transform.position = Vector3.Slerp(currentEmployee.transform.position, nextEmployee.transform.position, elapsedTime / cameraMoveTime);
        if (Vector3.Distance(this.transform.position, nextEmployee.transform.position) < 0.01f)
        {
            UnlockInputAndTurnOffBool(out switchingEmployees);
            currentEmployee = nextEmployee;
        }
    }

    private void LockInputAndTurnOnBool(out bool boolToTurnOn)
    {
        boolToTurnOn = true;
        lockInput = true;

    }

    private void UnlockInputAndTurnOffBool(out bool boolToTurnOff)
    {
        boolToTurnOff = false;
        lockInput = false;

    }

    void FixedUpdate()
    {
        currentEmployee.rigidBody2D.velocity = new Vector2(movementHorizontal * currentEmployee.moveSpeed, movementVertical * currentEmployee.moveSpeed);
    }
}
