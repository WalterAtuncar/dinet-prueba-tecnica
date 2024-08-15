import { Component, OnInit } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { RouterOutlet } from '@angular/router';
import { CommonModule } from '@angular/common'; 
import { HttpClientModule } from '@angular/common/http'; 
import { Product } from './app.modeel';  // Asegúrate de que el nombre del archivo es correcto y está en la misma carpeta
import { ProductService } from './product.service';


@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule,RouterOutlet,FormsModule, HttpClientModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css',
  providers: [ProductService]
})
export class AppComponent implements OnInit{
  products :Product[] = []
  newProduct :Product = {
    id: 0,
    nombre: '',
    precio: '',
    fechaCreacion: new Date()
  }
  constructor(private productService :ProductService){

  }
  ngOnInit(): void {
    this.loadData();
  }
  loadData() {
    this.productService.getProducts().subscribe( (data: any[]) =>{
      this.products = data;
      console.log("data", this.products)
    })
  }
  addProduct(){
    this.productService.addProduct(this.newProduct).subscribe((newProduct: Product) => {
      this.loadData();
      this.newProduct = { id: 0, nombre: '', precio: '', fechaCreacion: new Date() };
    });
  }
  title = 'product-list-app';
}
