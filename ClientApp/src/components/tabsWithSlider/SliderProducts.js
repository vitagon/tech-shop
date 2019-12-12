import React from "react";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faHeart, faExchangeAlt, faEye, faShoppingCart } from '@fortawesome/free-solid-svg-icons';
import { faHeart as faHeartO } from '@fortawesome/free-regular-svg-icons';

export const SliderProducts = (products) => {
  let sliderProductsElements = products.map((product, i) => {
    return (
      <div key={product.id} className="product-wrap">
        <div className="product">
          <div className="product-img">
            <img src={product.img} alt="" style={{ width: '100%' }} />
            {(product.sale !== '' || product.new !== false) &&
              <div className="product-label">
                {product.sale !== '' && <span className="sale">{product.sale}</span>}
                {product.new !== false && <span className="new">NEW</span>}
              </div>
            }
          </div>
          <div className="product-body">
            <p className="product-category">{product.category}</p>
            <h3 className="product-name"><a href="/">{product.name}</a></h3>
            <h4 className="product-price">{product.price} <del className="product-old-price">{product.oldPrice}</del></h4>
            <div className="product-rating">
              <FontAwesomeIcon icon={faHeart} />
              <FontAwesomeIcon icon={faHeartO} />
              <FontAwesomeIcon icon={faHeartO} />
              <FontAwesomeIcon icon={faHeartO} />
              <FontAwesomeIcon icon={faHeartO} />
            </div>
            <div className="product-btns">
              <button className="add-to-wishlist"><FontAwesomeIcon icon={faHeartO} /><span className="tooltipp">add to wishlist</span></button>
              <button className="add-to-compare"><FontAwesomeIcon icon={faExchangeAlt} /><span className="tooltipp">add to compare</span></button>
              <button className="quick-view"><FontAwesomeIcon icon={faEye} /><span className="tooltipp">quick view</span></button>
            </div>
          </div>
          <div className="add-to-cart">
            <button className="add-to-cart-btn"><FontAwesomeIcon icon={faShoppingCart} /> add to cart</button>
          </div>
        </div>
      </div>
    )
  });

  return sliderProductsElements;
}