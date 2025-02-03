import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { EmployeeService } from '../../Services/employee.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-employee-form',
  templateUrl: './employee-form.component.html',
  styleUrl: './employee-form.component.css'
})
export class EmployeeFormComponent  implements OnInit {
  employeeForm: FormGroup;
  isEditMode = false;
  isSubmitting = false;
  employeeId?: number;

  constructor(
    private formBuilder: FormBuilder,
    private employeeService: EmployeeService,
    private route: ActivatedRoute,
    private router: Router
  ) {
    this.employeeForm = this.formBuilder.group({
      name: ['', Validators.required],
      department: ['', Validators.required],
      position: ['', Validators.required],
      salary: ['', [Validators.required, Validators.min(0)]],
      joinDate: ['', Validators.required]
    });
  }

  ngOnInit(): void {
    this.employeeId = Number(this.route.snapshot.paramMap.get('id'));
    if (this.employeeId) {
      this.isEditMode = true;
      this.loadEmployee();
    }
  }

  loadEmployee(): void {
    if (this.employeeId) {
      this.employeeService.getEmployee(this.employeeId).subscribe({
        next: (employee) => {
          this.employeeForm.patchValue({
            ...employee,
            joinDate: new Date(employee.joinDate).toISOString().split('T')[0]
          });
        },
        error: (error) => console.error('Error loading employee:', error)
      });
    }
  }

  onSubmit(): void {
    if (this.employeeForm.invalid) return;

    this.isSubmitting = true;
    const employee = this.employeeForm.value;

    const request = this.isEditMode
      ? this.employeeService.updateEmployee({ ...employee, id: this.employeeId })
      : this.employeeService.createEmployee(employee);

    request.subscribe({
            next : () => this.router.navigate(['/employees']), 
            error : () => this.isSubmitting = false
    });
  }

  cancel(): void {
    this.router.navigate(['/employees']);
  }

}
