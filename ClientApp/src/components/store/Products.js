import React, { Component } from 'react';
import { ProductsGridView } from './products/ProductsGridView';
import ProductsListView from './products/ProductsListView';
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faTh, faThList, faAngleRight } from '@fortawesome/free-solid-svg-icons';
import './Products.css'

const products = [
  {
    id: 1,
    img: './img/product01.png',
    sale: '-30%',
    new: true,
    category: 'Category',
    name: 'Laptop ASUS Air G3425',
    description: '[Intel Celeron J4005, 2x2000 MGz, 4 GB DDR3, SSD 120 GB, without OS]',
    price: '150',
    oldPrice: '183',
    rating: 5
  },
  {
    id: 2,
    img: './img/product02.png',
    sale: '',
    new: true,
    category: 'Category',
    name: 'Headphones Lenovo C1124',
    description: '',
    price: '60',
    oldPrice: '72',
    rating: 0
  },
  {
    id: 3,
    img: './img/product03.png',
    sale: '-30%',
    new: false,
    category: 'Category',
    name: 'Laptop Mackbook Air 2',
    description: '',
    price: '980.00',
    oldPrice: '990.00',
    rating: 3
  },
  {
    id: 4,
    img: './img/product04.png',
    sale: '',
    new: false,
    category: 'Category',
    name: 'Tablet Sony Z3',
    description: '',
    price: '980.00',
    oldPrice: '990.00',
    rating: 5
  },
  {
    id: 5,
    img: './img/product05.png',
    sale: '',
    new: false,
    category: 'Category',
    name: 'Headphones Epson GT23',
    description: '',
    price: '980.00',
    oldPrice: '990.00',
    rating: 5
  },
  {
    id: 6,
    img: './img/product06.png',
    sale: '',
    new: false,
    category: 'Category',
    name: 'Laptop Acer H2451',
    description: '',
    price: '980.00',
    oldPrice: '990.00',
    rating: 4
  },
  {
    id: 7,
    img: './img/product07.png',
    sale: '',
    new: false,
    category: 'Category',
    name: 'Samsung Galaxy S8 Pro',
    description: '',
    price: '980.00',
    oldPrice: '990.00',
    rating: 2
  },
];

class Products extends Component {
  constructor(props) {
    super(props);
    this.state = {
      productsView: 'list'
    }
    this.setGridView = this.setGridView.bind(this);
    this.setListView = this.setListView.bind(this);
  }

  setGridView() {
    this.setState({
      ...this.state,
      productsView: 'grid'
    });
  }

  setListView() {
    this.setState({
      ...this.state,
      productsView: 'list'
    });
  }

  render() {
    return (
      <div id="store" class="col-md-9">
        <div class="store-filter clearfix">
          <div class="store-sort">
            <label>
              Sort By:
							<select class="input-select">
                <option value="0">Popular</option>
                <option value="1">Position</option>
              </select>
            </label>

            <label>
              Show:
							<select class="input-select">
                <option value="0">20</option>
                <option value="1">50</option>
              </select>
            </label>
          </div>
          <ul class="store-grid">
            <li class={this.state.productsView === 'grid' ? 'active' : ''} onClick={this.setGridView}><FontAwesomeIcon icon={faTh} /></li>
            <li class={this.state.productsView === 'list' ? 'active' : ''} onClick={this.setListView}><FontAwesomeIcon icon={faThList} /></li>
          </ul>
        </div>

        <div class="row">
          {this.state.productsView === 'grid' && ProductsGridView(products)}
          {this.state.productsView === 'list' && <ProductsListView products={products} />}
        </div>

        <div class="store-filter clearfix">
          <span class="store-qty">Showing 20-100 products</span>
          <ul class="store-pagination">
            <li class="active">1</li>
            <li><a href="#">2</a></li>
            <li><a href="#">3</a></li>
            <li><a href="#">4</a></li>
            <li><a href="#"><FontAwesomeIcon icon={faAngleRight}/></a></li>
          </ul>
        </div>
      </div>
    )
  }
}

export default Products;
