import React from 'react';
import './components.css';

const Card = ({ extraClassNames = [], children, callOnClick }) => {
	const extraClasses = extraClassNames.length > 0 ? ' ' + extraClassNames.join(' ') : '';
	const clickableProps = callOnClick
		? {
				role: 'button',
				tabIndex: 0,
				onClick: callOnClick,
				onKeyDown: (event) => {
					if (event.key !== 'Enter' && event.key !== ' ') return;

					event.preventDefault();
					callOnClick();
				}
			}
		: {};

	return (
		<div className={`card${extraClasses}`} {...clickableProps}>
			{children}
		</div>
	);
};

export default Card;
