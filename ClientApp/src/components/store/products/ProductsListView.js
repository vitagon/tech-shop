import React from "react";
import { FontAwesomeIcon } from '@fortawesome/react-fontawesome';
import { faStar, faExchangeAlt, faEye, faShoppingCart } from '@fortawesome/free-solid-svg-icons';
import { faHeart as faHeartO, faStar as faStarO } from '@fortawesome/free-regular-svg-icons';
import styles from './ProductsListView.module.css';
import { connect } from 'react-redux';
import { bindActionCreators } from 'redux';
import { addItemToCart } from "../../../actions/cartActions";

class ProductsListView extends React.Component {

  render() {
    let productsListElement = this.props.products.map((product, i) => {
      let oneToFiveArray = [];
      for (let i = 0; i < 5; i++) {
        oneToFiveArray[i] = i + 1;
      }
      let isInCart = this.props.items && this.props.items.find(x => x.product.id == product.id) && true;
      return (
        <div key={product.id} className={styles['product-wrap']}>
          <div className="product">
            <div className={styles['product__main']}>
              <div className={styles['product-img']}>
                <img src={product.img} alt="" />
                {(product.sale !== '' || product.new !== false) &&
                  <div className={styles['product-label']}>
                    {product.sale !== '' && <span className={styles['sale']}>{product.sale}</span>}
                    {product.new !== false && <span className={styles['new']}>NEW</span>}
                  </div>
                }
                <div className={styles['product-rating']}>
                  {oneToFiveArray.map((value, i) => {
                    return product.rating >= value ?
                      (<FontAwesomeIcon icon={faStar} className={styles['fa-star']} key={i} />) :
                      (<FontAwesomeIcon icon={faStarO} className={styles['fa-star']} key={i} />)
                  })}
                </div>
              </div>
              <div className={styles['product-body']}>
                <div className={styles['top-panel']}>
                  <div className={styles['product-info__title']}>
                    <h3 className={styles['product-name']}><a href="/">{product.name}</a></h3>
                    <span className={styles['product-description']}>{product.description}</span>
                  </div>

                  <div className={styles['product-price']}>${product.price} <del className={styles['product-old-price']}>${product.oldPrice}</del></div>
                </div>


                <div className={styles['product-options']}>
                  <div className={styles['left-panel']}>
                    <button className={styles['add-to-wishlist']}><FontAwesomeIcon icon={faHeartO} /><span className={styles['tooltipp']}>add to wishlist</span></button>
                    <button className={styles['add-to-compare']}><FontAwesomeIcon icon={faExchangeAlt} /><span className={styles['tooltipp']}>add to compare</span></button>
                    <button className={styles['quick-view']}><FontAwesomeIcon icon={faEye} /><span className={styles['tooltipp']}>quick view</span></button>
                  </div>

                  <button className={styles['buy-btn']} onClick={() => { this.props.addToCart(product) }}>
                    {isInCart ? 'In cart' : 'Buy'}
                  </button>
                </div>
              </div>
            </div>

            {/*<div className="product__footer">
            <div className="product-btns">
              <div className="left-panel">
                <button className="add-to-wishlist"><FontAwesomeIcon icon={faHeartO} /><span className="tooltipp">add to wishlist</span></button>
                <button className="add-to-compare"><FontAwesomeIcon icon={faExchangeAlt} /><span className="tooltipp">add to compare</span></button>
                <button className="quick-view"><FontAwesomeIcon icon={faEye} /><span className="tooltipp">quick view</span></button>
              </div>
              
              <button className="buy-btn">Buy</button>
            </div>
          </div>*/}

            {/*<div className="add-to-cart">
            <button className="add-to-cart-btn"><FontAwesomeIcon icon={faShoppingCart} /> add to cart</button>
          </div>*/}
          </div>
        </div>
      )
    });

    return (
      <div className={styles['list-view']}>
        {productsListElement}
      </div>
    );
  }
}

const mapStateToProps = (state, ownProps) => {
  return {
    items: state.cartReducer.cartItems
  }
}

const mapDispatchToProps = (dispatch) => bindActionCreators({
  addToCart: addItemToCart
}, dispatch);

export default connect(mapStateToProps, mapDispatchToProps)(ProductsListView);