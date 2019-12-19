import React from "react";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faStar, faExchangeAlt, faEye, faShoppingCart } from '@fortawesome/free-solid-svg-icons';
import { faHeart as faHeartO, faStar as faStarO } from '@fortawesome/free-regular-svg-icons';
import styles from './../../../styles/Product.module.css';

export const ProductsGridView = (products) => {
  let oneToFiveArray = [];
  for (let i = 0; i < 5; i++) {
    oneToFiveArray[i] = i + 1;
  }
  let productsListElement = products.map((product, i) => {
    return (
      <div key={product.id} className="col-md-4 col-xs-6">
        <div className={styles.product}>
          <div className={styles['product-img']}>
            <img src={product.img} alt="" style={{ width: '100%' }} />
            {(product.sale !== '' || product.new !== false) &&
              <div className={styles['product-label']}>
                {product.sale !== '' && <span className={styles.sale}>{product.sale}</span>}
                {product.new !== false && <span className={styles.new}>NEW</span>}
              </div>
            }
          </div>
          <div className={styles['product-body']}>
            <p className={styles['product-category']}>{product.category}</p>
            <h3 className={styles['product-name']}><a href="/">{product.name}</a></h3>
            <h4 className={styles['product-price']}>{product.price} <del className={styles['product-old-price']}>{product.oldPrice}</del></h4>
            <div className={styles['product-rating']}>
              {oneToFiveArray.map((value, i) => {
                return product.rating >= value ?
                  (<FontAwesomeIcon icon={faStar} className={styles['fa-star']} key={i} />) :
                  (<FontAwesomeIcon icon={faStarO} className={styles['fa-star']} key={i} />)
              })}
            </div>
            <div className={styles['product-btns']}>
              <button className="add-to-wishlist"><FontAwesomeIcon icon={faHeartO} /><span className={styles['tooltipp']}>add to wishlist</span></button>
              <button className="add-to-compare"><FontAwesomeIcon icon={faExchangeAlt} /><span className={styles['tooltipp']}>add to compare</span></button>
              <button className="quick-view"><FontAwesomeIcon icon={faEye} /><span className={styles['tooltipp']}>quick view</span></button>
            </div>
          </div>
          <div className={styles['add-to-cart']}>
            <button className={styles['add-to-cart-btn']}><FontAwesomeIcon icon={faShoppingCart} /> add to cart</button>
          </div>
        </div>
      </div>
    )
  });

  return productsListElement;
}